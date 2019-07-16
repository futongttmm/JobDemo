using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Castle.Facilities.Logging;
using Abp.AspNetCore;
using Abp.Castle.Logging.Log4Net;
using Job.Authentication.JwtBearer;
using Job.Configuration;
using Job.Identity;
using Job.Web.Resources;
using Abp.AspNetCore.SignalR.Hubs;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Configuration;
using Microsoft.AspNet.Identity;
using Abp.Authorization.Users;
using Job.Authorization.Roles;
using Job.Authorization.Users;
using Abp.Authorization.Roles;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using Job.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Job.Web.Startup
{
    public class Startup
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Startup(IHostingEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("/MyAreas/{2}/Views/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/MyAreas/{2}/Views/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            });

            services.AddDbContext<JobDbContext>(options => options.UseSqlServer("Server=localhost; Database=JobDb; Trusted_Connection=True;"));

            IdentityRegistrar.Register(services);
            AuthConfigurer.Configure(services, _appConfiguration);

            // Use it after IdentityRegistrar.Register
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Admin/Account/Login";

                //both of those two methods work well

                //options.Events = new CookieAuthenticationEvents
                //{
                //    OnRedirectToLogin = ctx => {
                //        var requestPath = ctx.Request.Path;
                //        if (requestPath.StartsWithSegments("/Admin"))
                //        {
                //            ctx.Response.Redirect("/Admin/Account/Login");
                //        }
                //        else
                //        {
                //            ctx.Response.Redirect("/Admin/Account/Login");
                //        }
                //        return Task.CompletedTask;
                //    }
                //};
            });

            // MVC
            services.AddMvc(
                options => options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute())
            );


            services.AddScoped<IWebResourceManager, WebResourceManager>();

            services.AddSignalR();

            // Configure Abp and Dependency Injection
            return services.AddAbp<JobWebMvcModule>(
                // Configure Log4Net logging
                options => options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig("log4net.config")
                )
            );
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(); // Initializes ABP framework.

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseJwtTokenMiddleware();

            app.UseSignalR(routes =>
            {
                routes.MapHub<AbpCommonHub>("/signalr");
            });

            app.UseMvc(routes =>
            {


                //routes.MapRoute(
                //    name: "defaultWithArea",
                //    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "defaultWhitUser",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );

                routes.MapRoute(
                    name: "default",
                    template: "{area=Admin}/{controller=Account}/{action=Login}/{id?}");


            });
        }
    }
}
