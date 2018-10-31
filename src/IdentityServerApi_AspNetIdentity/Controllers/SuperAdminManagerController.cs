using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IdentityServerApi_AspNetIdentity.DTO.UserDto;
using IdentityServerApi_AspNetIdentity.Models.UserModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IdentityServerApi_AspNetIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "SuperAdmin")]
    [Authorize(Policy = "SuperAdminOnly")]
    public class SuperAdminManagerController : ControllerBase
    {
        ////TODO: Супер админ получает доступ к api по добавлению новых фирм.
        //// Для фирмы обязательно добавляется админ (без этого фирма не добавляется в БД)
        //// Также полный доступ над всеми пользователями всех фирм (При загрузке страницы выдает всех пользователей всех фирм (кроме супер админа))

        //#region field

        //private readonly IMapper _mapper;
        //private readonly UserManager<ApplicationUser> _userManager;

        //#endregion



        //#region ctor

        //public SuperAdminManagerController(IMapper mapper, UserManager<ApplicationUser> userManager)
        //{
        //    _mapper = mapper;
        //    _userManager = userManager;
        //}

        //#endregion




        //// GET api/SuperAdminManager

        //#region Api

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var claims = from c in User.Claims select new { c.Type, c.Value };
        //    claims = claims.ToList();
        //    var name = User.Identity.Name;
        //    var companyNAnme = User.FindFirst("CompanyName").Value;
        //    var roles = claims.Where(c => c.Type == "role").Select(c => c.Value).ToList();

        //    var users = _userManager.Users.Include(u => u.Company).ToList();

        //    var userClaims = await _userManager.GetClaimsAsync(users.First());
        //    var usersSuperAdmin = await _userManager.GetUsersInRoleAsync("SuperAdmin");
        //    try
        //    {
        //        //var user2 = new ApplicationUser2
        //        //{
        //        //    Id = "1111",
        //        //    UserName = "rewrwer",
        //        //    Company = new Company { Id = 1, Name = "Scoring" }
        //        //};
        //        //var usersDto2 = _mapper.Map<ApplicationUserDto>(user2);


        //        var usersDto = _mapper.Map<ApplicationUserDto>(users);     //TODO: почему не рабоатет маппинг? И спросить про патерн репозиторий
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    await Task.CompletedTask;
        //    return new JsonResult(users);
        //}



        //#endregion

    }
}