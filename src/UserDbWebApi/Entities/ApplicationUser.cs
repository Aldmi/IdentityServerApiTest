using IdentityServerApi_AspNetIdentity.Models.UserModel;
using Microsoft.AspNetCore.Identity;

namespace UserDbWebApi.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public Company Company { get; set; }
    }
}
