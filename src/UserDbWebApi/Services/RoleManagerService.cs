using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserDbWebApi.Data;
using UserDbWebApi.DTO.RolesDto;


namespace UserDbWebApi.Services
{
    public class RoleManagerService
    {
        private readonly ApplicationDbContext _context;


        #region ctor

        public RoleManagerService(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion


        /// <summary>
        /// Вернуть все роли кроме SuperAdmin
        /// </summary>
        /// <returns></returns>
        public async Task<List<RoleDto>> GetAll()
        {
            var rolesDto = new List<RoleDto>();
            var roles = await _context.Roles.Where(r => r.Name != "SuperAdmin").ToListAsync();
            foreach (var role in roles)
            {
                var roleClaims = await _context.RoleClaims.Where(c => c.RoleId == role.Id).ToListAsync();
                rolesDto.Add(new RoleDto
                {
                    Id = role.Id,
                    Name = role.Name,
                    Claims = roleClaims?.ToDictionary(claim => claim.ClaimType, claim => claim.ClaimValue)
                });
            }
            return rolesDto;
        }


        /// <summary>
        /// Наличие роли по имени
        /// </summary>
        public async Task<bool> RoleExistsAsync(string name) => await _context.Roles.FirstOrDefaultAsync(r => r.Name == name) != null;



        /// <summary>
        /// Получить роль по имени.
        /// </summary>
        public async Task<RoleDto> GetRoleAsync(string name)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == name);
            if (role == null)
                throw new Exception($"Роль не найденна по имени {name}");

            var roleClaims = await _context.RoleClaims.Where(c => c.RoleId == role.Id).ToListAsync();
            var roleDto= new RoleDto
            {
                Id = role.Id,
                Name = role.Name,
                Claims = roleClaims?.ToDictionary(claim => claim.ClaimType, claim => claim.ClaimValue)
            };
            return roleDto;
        }



        /// <summary>
        /// Добавить Роль.
        /// </summary>
        public async Task<bool> AddRoleAsync(RoleDto roleDto)
        {
           var res= await _context.Roles.AddAsync(new IdentityRole(roleDto.Name));
           await _context.SaveChangesAsync();
           var addedRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == res.Entity.Name);
           if (addedRole != null)
           {
               var identityRoleClaims = roleDto.Claims.Select(c => new IdentityRoleClaim<string> {ClaimType = c.Key, ClaimValue = c.Value, RoleId = addedRole.Id}).ToList();
               await _context.RoleClaims.AddRangeAsync(identityRoleClaims);
               await _context.SaveChangesAsync();
               return true;
            }
            return false;
        }


        /// <summary>
        /// Редактировать Роль.
        /// </summary>
        public async Task<bool> EditRoleAsync(RoleDto roleDto)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Id == roleDto.Id);
            if (role == null)
                return false;

            role.Name = roleDto.Name;
            var res = _context.Roles.Update(role);

            var claimsCurrent = await _context.RoleClaims.Where(c => c.RoleId == role.Id).ToListAsync();
            foreach (var claim in claimsCurrent)
            {
                if (roleDto.Claims.ContainsKey(claim.ClaimType))
                {
                    claim.ClaimValue= roleDto.Claims[claim.ClaimType];
                }
            }

            _context.RoleClaims.UpdateRange(claimsCurrent);
            await _context.SaveChangesAsync();
            return (res.State == EntityState.Modified);
        }



        /// <summary>
        /// Удалить Роль.
        /// </summary>
        public async Task<bool> RemoveRoleAsync(string roleName)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
            if (role == null)
                return false;

            var res = _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
            return (res.State == EntityState.Deleted);
        }
    }
}