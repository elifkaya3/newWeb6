using DurkayaRecipe.Business.Abstract;
using DurkayaRecipe.Business.Concrete;
using DurkayaRecipe.Data.Abstract;
using DurkayaRecipe.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DurkayaRecipe.WebUI
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
            services.AddScoped<IFoodRepository, EfCoreFoodRepository>();
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<IFoodService, FoodManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "adminfoodcreate",
                    pattern: "admin/foods/create",
                    defaults: new { controller = "Admin", action = "FoodCreate" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminfoods",
                    pattern: "admin/foods",
                    defaults: new { controller = "Admin", action = "FoodList" }
                    );

                endpoints.MapControllerRoute(
                   name: "search",
                   pattern: "search",
                   defaults: new { controller = "DurkayaRecipe", action = "Search" }
                   );

                endpoints.MapControllerRoute(
                   name: "foods",
                   pattern: "foods/{category?}",
                   defaults: new { controller = "DurkayaRecipe", action = "List" }
                   );

                endpoints.MapControllerRoute(
                   name: "adminfoodedit",
                   pattern: "admin/foods/{id?}",
                   defaults: new { controller = "Admin", action = "FoodEdit" }
                   );

                endpoints.MapControllerRoute(
                   name: "fooddetails",
                   pattern: "{url}",
                   defaults: new { controller = "DurkayaRecipe", action = "Details" }
                   );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
