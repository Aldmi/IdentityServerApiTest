

using System.Collections.Generic;
using UserDbWebApi.Entities;

namespace IdentityServerApi_AspNetIdentity.Models.UserModel
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}