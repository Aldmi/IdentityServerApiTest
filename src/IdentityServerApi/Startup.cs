using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4;
using IdentityServer4.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace IdentityServerApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // configure identity server with in-memory stores, keys, clients and scopes
            services.AddIdentityServer(options =>
                {
                    options.Endpoints = new EndpointsOptions
                    {
                        // в Implicit Flow используется для получения токенов
                        EnableAuthorizeEndpoint = true,
                        // для получения статуса сессии
                        EnableCheckSessionEndpoint = true,
                        // для логаута по инициативе пользователя
                        EnableEndSessionEndpoint = true,
                        // для получения claims аутентифицированного пользователя 
                        // http://openid.net/specs/openid-connect-core-1_0.html#UserInfo
                        EnableUserInfoEndpoint = true,
                        // используется OpenId Connect для получения метаданных
                        EnableDiscoveryEndpoint = true,

                        // для получения информации о токенах, мы не используем
                        EnableIntrospectionEndpoint = false,
                        // нам не нужен т.к. в Implicit Flow access_token получают через authorization_endpoint
                        EnableTokenEndpoint = false,
                        // мы не используем refresh и reference tokens 
                        // http://docs.identityserver.io/en/release/topics/reference_tokens.html
                        EnableTokenRevocationEndpoint = false
                    };
                    // IdentitySever использует cookie для хранения своей сессии
                    options.Authentication = new AuthenticationOptions
                    {
                        CookieLifetime = TimeSpan.FromDays(1)
                    };
                })
                .AddDeveloperSigningCredential()                              // тестовый x509-сертификат, IdentityServer использует RS256 для подписи JWT
                .AddInMemoryIdentityResources(Config.GetIdentityResources())  // что включать в id_token
                .AddInMemoryApiResources(Config.GetApiResources())            // что включать в access_token
                .AddInMemoryClients(Config.GetClients())                      //настройки клиентских приложений
                .AddTestUsers(Config.GetUsers());                             //пользователи


            //services.AddAuthentication()
            //    .AddGoogle("Google", options =>
            //    {
            //        options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

            //        options.ClientId = "434483408261-55tc8n0cs4ff1fe21ea8df2o443v2iuc.apps.googleusercontent.com";
            //        options.ClientSecret = "3gcoTrEDPPJ0ukn_aYYT6PWo";
            //    })
            //    .AddOpenIdConnect("oidc", "OpenID Connect", options =>
            //    {
            //        options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
            //        options.SignOutScheme = IdentityServerConstants.SignoutScheme;

            //        options.Authority = "https://demo.identityserver.io/";
            //        options.ClientId = "implicit";

            //        options.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            NameClaimType = "name",
            //            RoleClaimType = "role"
            //        };
            //    });
        }



        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseIdentityServer();

            app.UseMvcWithDefaultRoute();
        }
    }
}