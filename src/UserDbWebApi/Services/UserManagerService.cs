using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserDbWebApi.Data;
using UserDbWebApi.DTO.UserDto;
using UserDbWebApi.Entities;

namespace UserDbWebApi.Services
{
    public class UserManagerService
    {
        private readonly ApplicationDbContext _context;


        #region ctor

        public UserManagerService(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion




        #region Api

        /// <summary>
        /// Вернуть всех пользователей
        /// </summary>
        public async Task<List<ApplicationUserDto>> GetAll()
        {
            var usersDto = new List<ApplicationUserDto>();
            var users = await _context.Users.Include(user => user.Company).ToListAsync();
            foreach (var user in users)
            {
                var userDto = new ApplicationUserDto
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Password = user.PasswordHash,
                    Company = new CompanyDto { Id = user.Company.Id, Name = user.Company.Name },
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                };
                //РОЛЬ
                var role = await GetRoleByUserIdAsync(user.Id);
                userDto.RoleName = role.Name;

                //КЛЕЙМЫ
                var userClaims = await GetUserClaimsAsync(user.Id);
                if (userClaims != null)
                {
                    userDto.Claims = userClaims.ToDictionary(claim => claim.ClaimType, claim => claim.ClaimValue);
                }
                usersDto.Add(userDto);
            }

            return usersDto.Where(u => u.RoleName != "SuperAdmin").ToList();
        }


        public async Task<List<ApplicationUserDto>> GetAllUsersCompany(string companyName)
        {
            var usersDto = new List<ApplicationUserDto>();
            var users = await _context.Users.Where(user=> user.Company.Name == companyName).Include(user=> user.Company).ToListAsync();
            foreach (var user in users)
            {
                var userDto = new ApplicationUserDto
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Password = user.PasswordHash,
                    Company = new CompanyDto { Id = user.Company.Id, Name = user.Company.Name },
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                };
                //РОЛЬ
                var role = await GetRoleByUserIdAsync(user.Id);
                userDto.RoleName = role.Name;

                //КЛЕЙМЫ
                var userClaims = await GetUserClaimsAsync(user.Id);
                if (userClaims != null)
                {
                    userDto.Claims = userClaims.ToDictionary(claim => claim.ClaimType, claim => claim.ClaimValue);
                }
                usersDto.Add(userDto);
            }

            return usersDto.Where(u => u.RoleName != "SuperAdmin").ToList();
        }


        /// <summary>
        /// Проверяет есть ли компания по имени.
        /// </summary>
        public async Task<bool> CompanyExistsAsync(string companyName) =>
             await _context.Companys.FirstOrDefaultAsync(company => company.Name == companyName) != null;



        /// <summary>
        /// Получить все компании
        /// </summary>
        public async Task<List<CompanyDto>> GetAllCompanys() =>
            await _context.Companys.Where(company => company.Name != "Супер Компания").Select(company => new CompanyDto { Name = company.Name }).ToListAsync();


        /// <summary>
        /// Добавить новую компанию
        /// </summary>
        public async Task<EntityState> AddNewCompany(CompanyDto companyDto)
        {
           var res= await _context.Companys.AddAsync(new Company {Name = companyDto.Name});
           await _context.SaveChangesAsync();
           return res.State;
        }


        /// <summary>
        /// Проверяет есть ли компания по имени.
        /// </summary>
        public async Task<bool> UserExistsAsync(string userName, string companyName) =>
            await _context.Users.Where(u=>u.Company.Name == companyName).FirstOrDefaultAsync(u => u.UserName == userName) != null;


        /// <summary>
        /// Добавить Нового пользователя
        /// ConcurrencyStamp - (random value) изменяется всегда когда пользователь сохраняется в БД
        /// SecurityStamp - (random value) изменяется всегда когда меняются данные учетной записи пользователя.
        /// </summary>
        public async Task<EntityState> AddNewUser(ApplicationUserDto userDto)
        {
          var company= await _context.Companys.FirstOrDefaultAsync(c => c.Name == userDto.Company.Name);
          if(company == null)
             throw new Exception($"Компания не найденна {userDto.Company.Name}");

           var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == userDto.RoleName);
           if (role == null)
              throw new Exception($"Роль не найденна {userDto.RoleName}");


           //Сохранить нового юзера (для присвоения Id)
           var newUser = new ApplicationUser
           {
               UserName = userDto.UserName,
               Email =userDto.Email,
               PhoneNumber = userDto.PhoneNumber,
               PasswordHash = userDto.Password,
               Company = company,
               NormalizedUserName = userDto.UserName.ToUpper(),
               NormalizedEmail = userDto.Email?.ToUpper(),
               ConcurrencyStamp = Guid.NewGuid().ToString(),
               SecurityStamp = Guid.NewGuid().ToString()
           };
           var res = await _context.Users.AddAsync(newUser);
           await _context.SaveChangesAsync();

            //var addedUser= _context.Users.FirstOrDefaultAsync(user=> (user.Company.Id == company.Id) && ())

            //var claims = userDto.Claims.Select(claim => new IdentityUserClaim<string>
            //{
            //    ClaimType = claim.Key,
            //    ClaimValue = claim.Value,
            //    UserId = ""
            //}).ToList();

            //await _context.UserClaims.AddRangeAsync(claims);



            return res.State;
        }


        #endregion



        #region Methods

        private async Task<IdentityRole> GetRoleByUserIdAsync(string userId)
        {
            var userRole = await _context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == userId);
            if (userRole == null)
                throw new Exception($"Роль не найденна для этого пользователя {userId}");

            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Id == userRole.RoleId);
            return role;
        }


        private async Task<List<IdentityUserClaim<string>>> GetUserClaimsAsync(string userId)
        {
            var userClaims = await _context.UserClaims.Where(uc => uc.UserId == userId).ToListAsync();
            return userClaims;
        }




        #endregion
    }
}