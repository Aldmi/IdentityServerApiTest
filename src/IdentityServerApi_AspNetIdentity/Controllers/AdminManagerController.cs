using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServerApi_AspNetIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize(Roles = "Admin")]
    //[Authorize(Policy = "AdminOnly")]
    public class AdminManagerController : ControllerBase
    {

        // GET api/AdminManager
        [HttpGet]
        //[Authorize(Roles = "admin")]
        //[Authorize(Policy = "AdminsOnly")]
        //[Authorize(Policy = "ManagerOnly")]
        [Authorize(Policy = "SuperAdminORAccess2AddingNewOrder")]
        public ActionResult<IEnumerable<string>> Get()
        {
            var claims = from c in User.Claims select new {c.Type, c.Value};

            var name = User.Identity.Name;

            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}