// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Mappers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using System.Reflection;

namespace IdentityServer
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }

        public Startup(IWebHostEnvironment environment)
        {
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
            const string connectionString = @"Data Source=ASUS-ROG-DANNY\SQLEXPRESS;database=DB_Identityserver4;User ID=sa;Password=sasa;trusted_connection=yes;";

            // uncomment, if you want to add an MVC-based UI
            services.AddControllersWithViews();

            var builder = services.AddIdentityServer()
                .AddTestUsers(TestUsers.Users)
                .AddConfigurationStore(options =>
                {
                    options.ConfigureDbContext = b => b.UseSqlServer(connectionString,
                        sql => sql.MigrationsAssembly(migrationsAssembly));
                })
                .AddOperationalStore(options =>
                {
                    options.ConfigureDbContext = b => b.UseSqlServer(connectionString,
                        sql => sql.MigrationsAssembly(migrationsAssembly));
                });
                //.AddInMemoryIdentityResources(Config.Ids)
                //.AddInMemoryApiResources(Config.Apis)
                //.AddInMemoryClients(Config.Clients);
                

            // not recommended for production - you need to store your key material somewhere secure
            builder.AddDeveloperSigningCredential();
            //builder.AddCookieAuthentication();
            //    builder.Services.ConfigureExternalCookie(options =>
            //    {
            //        options.Cookie.IsEssential = true;
            //        options.Cookie.SameSite = (SameSiteMode)(-1);
            //    });
            //    builder.Services.ConfigureApplicationCookie(options =>
            //    {
            //        options.Cookie.IsEssential = true;
            //        options.Cookie.SameSite = (SameSiteMode)(-1);


            //    });
        }

        public void Configure(IApplicationBuilder app)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Inicializa la base de datos para nuestro contexto de identity resource
            // Comentar esta region una vez se hizo la primer migracion
            //InitializeDatabase(app);
            // comentar linea superior una vez se hizo la primer migracion



            // uncomment if you want to add MVC
            app.UseStaticFiles();
            app.UseRouting();

            app.UseIdentityServer();

            // uncomment, if you want to add MVC
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }

        private void InitializeDatabase(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetRequiredService<PersistedGrantDbContext>().Database.Migrate();

                var context = serviceScope.ServiceProvider.GetRequiredService<ConfigurationDbContext>();
                context.Database.Migrate();

                if (!context.Clients.Any())
                {
                    foreach (var client in Config.Clients)
                    {
                        context.Clients.Add(client.ToEntity());
                    }
                    context.SaveChanges();
                }

                if (!context.IdentityResources.Any())
                {
                    foreach(var recource in Config.Ids)
                    {
                        context.IdentityResources.Add(recource.ToEntity());
                    }
                    context.SaveChanges();
                }

                if (!context.ApiResources.Any())
                {
                    foreach(var api in Config.Apis)
                    {
                        context.ApiResources.Add(api.ToEntity());
                    }
                    context.SaveChanges();
                }

            }

        }
        
    }
}
