using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserDbWebApi.DTO.RolesDto;

namespace UserDbWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "SuperAdmin")]
    public class RoleManagerController : ControllerBase
    {
        #region field

        private readonly RoleManager<IdentityRole> _roleManager;

        #endregion




        #region ctor

        public RoleManagerController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        #endregion




        #region Api

        // GET api/RoleManager
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var rolesDto = new List<RoleDto>();
            var roles = _roleManager.Roles.Where(r => r.Name != "SuperAdmin").ToList();
            if (!roles.Any())
            {
                return NoContent();
            }
            foreach (var role in roles)
            {
                var roleClaims = await _roleManager.GetClaimsAsync(role);
                rolesDto.Add(new RoleDto
                {
                    Id = role.Id,
                    Name = role.Name,
                    Claims = roleClaims.ToDictionary(claim => claim.Type, claim => claim.Value)
                });
            }

            return new JsonResult(rolesDto);
        }



        // POST api/RoleManager
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RoleDto data)
        {
            if (data == null)
            {
                ModelState.AddModelError("RoleDto", "POST body is null");
                return BadRequest(ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (await _roleManager.RoleExistsAsync(data.Name))
            {
                return BadRequest($"Роль с таким именем уже существует {data.Name}");
            }

            // добавить РОЛЬ
            var role = new IdentityRole(data.Name);
            var result = _roleManager.CreateAsync(role).Result;
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.First().Description);
            }

            // добавить КЛЕЙМЫ
            var claims = data.Claims.Select(c => new Claim(c.Key, c.Value)).ToList();
            foreach (var claim in claims)
            {
                result = _roleManager.AddClaimAsync(role, claim).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
            }

            return Ok();
        }



        // PUT api/RoleManager/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> EditRole([FromRoute]string id, [FromBody]RoleDto data)
        {
            if (id == data.Id)
            {
                var role = await _roleManager.FindByIdAsync(id);
                //Обновить НАЗВАНИЕ РОЛИ
                role.Name = data.Name;
                var result = await _roleManager.UpdateAsync(role);
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                //удалить текущие КЛЕЙМЫ
                var claimsCurrent = await _roleManager.GetClaimsAsync(role);
                foreach (var claim in claimsCurrent)
                {
                    result = await _roleManager.RemoveClaimAsync(role, claim);
                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                }

                //добавить новые КЛЕЙМЫ
                var claims = data.Claims.Select(c => new Claim(c.Key, c.Value)).ToList();
                foreach (var claim in claims)
                {
                    result = _roleManager.AddClaimAsync(role, claim).Result;
                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                }

                return Ok(data);
            }
            return NotFound("Id не совпадают");
        }



        // DELETE api/RoleManager/Admin
        [HttpDelete("{roleName}")]
        public async Task<IActionResult> Delete([FromRoute]string roleName)
        {
            if (!(await _roleManager.RoleExistsAsync(roleName)))
            {
                return NotFound(roleName);
            }
            var role = await _roleManager.FindByNameAsync(roleName);
            var result = await _roleManager.DeleteAsync(role);
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.First().Description);
            }
            return Ok(role);
        }

         #endregion
    }
}