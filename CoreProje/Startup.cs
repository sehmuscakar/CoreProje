using DataAccessLayer.Concrete;
using EntityLayer.conrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>();// bunu ekledik
            services.AddIdentity<WriterUser,WriterRole>().AddEntityFrameworkStores<Context>();//bunuda ekledik
            services.AddControllersWithViews();
            // bular� ekledik 
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();// sisteme otantik olan bir kullan�c� gerekli
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
            //{
            //    x.LoginPath = "/AdminLogin/Index/";// e�er sisteme giri� yap�lamad�ysa beni �uraya y�nlendir

            //});

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;//identity ba�l� metotlar 
                options.ExpireTimeSpan = TimeSpan.FromMinutes(100); //100 dakika otontik olarak kalabilecek 
                options.AccessDeniedPath = "/ErrorPage/Index/";//eri�ime reddildi�inde bu sayfaya y�nlendirilecek
                options.LoginPath ="/Writer/Login/Index/";

            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseStatusCodePages();// bunu biz ekledik 404 sayfas�na g�nderecek 
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/");// burda bizim istedi�imiz sayfaya y�nlendirecek



            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();// bunu ekledik ,�unun i�in user sayfas�ndan writer/default/�ndex sayfas�na gitsin diye 
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
                );
            });


        }
    }
}
