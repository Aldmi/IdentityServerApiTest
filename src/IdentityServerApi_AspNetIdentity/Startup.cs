﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IdentityServer4.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IdentityServerApi_AspNetIdentity.Policy;
using IdentityServerApi_AspNetIdentity.Services;
using UserDbWebApi.Data;
using UserDbWebApi.Entities;

namespace IdentityServerApi_AspNetIdentity
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }



        public void ConfigureServices(IServiceCollection services)
        {
            //Контекст имеет scope НЕ PerRequest а берется из пула (переиспользуется)
            services.AddDbContextPool<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddAutoMapper();
            services.AddMvc();
            services.AddAuthorization(MyAuthorizationPolicy.AddPolicy);

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
            .AddInMemoryPersistedGrants()
            .AddInMemoryIdentityResources(Config.GetIdentityResources())  // что включать в id_token
            .AddInMemoryApiResources(Config.GetApiResources())            // что включать в access_token
            .AddInMemoryClients(Config.GetClients())                      // настройки клиентских приложений
            .AddAspNetIdentity<ApplicationUser>();                        // пользователи


            services.AddCors(options =>
            {
                // задаём политику CORS, чтобы наше клиентское приложение могло отправить запрос на сервер API
                options.AddPolicy("default", policy =>
                {
                    policy.WithOrigins("http://localhost:5003")
                        .AllowAnyHeader() // принимаются запросы с любыми заголовками
                        .AllowAnyMethod() // принимаются запросы с на все HTTP методы
                        .AllowCredentials();
                });
            });
        }



        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseCors("default");
            app.UseStaticFiles();
            app.UseIdentityServer();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
