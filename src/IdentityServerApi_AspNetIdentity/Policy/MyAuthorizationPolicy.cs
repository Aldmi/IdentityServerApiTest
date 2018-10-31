using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace IdentityServerApi_AspNetIdentity.Policy
{
    public class MyAuthorizationPolicy
    {
        public static void AddPolicy(AuthorizationOptions options)
        {
            options.AddPolicy("SuperAdminOnly", policyUser =>
            {
                policyUser.RequireClaim("role", "SuperAdmin");
            });
            options.AddPolicy("AdminOnly", policyUser =>
            {
                policyUser.RequireClaim("role", "admin");
            });
            options.AddPolicy("ManagerOnly", policyUser =>
            {
                policyUser.RequireClaim("role", "manager");
                //policyUser.RequireClaim("Access2Read", "true");
            });

            //options.AddPolicy("BadgeEntry", policy =>
            //    policy.RequireAssertion(context =>

            //        context.User.HasClaim(c =>
            //            (c. == ClaimTypes. ||
            //             c.Type == ClaimTypes.TemporaryBadgeId) &&
            //             c.Issuer == "https://microsoftsecurity")));


            options.AddPolicy("SuperAdminORAccess2AddingNewOrder", policy =>
                policy.RequireAssertion(context =>
                {
                  var isSuperAdmin= context.User.IsInRole("SuperAdmin");
                  var access2AddingNewOrder= context.User.HasClaim(claim => claim.Type == "Access2AddingNewOrder" && claim.Value == "true");
                  return isSuperAdmin || access2AddingNewOrder;
                }));
        }
    }
}