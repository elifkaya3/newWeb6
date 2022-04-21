using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //bu uygulamada kullanýlacak olan servislerin belirlendiði metottur.
            //Service demek belli bi takým iþleri yapmak kodlarýn içinde bulunduðu yapýlardýr.
            //modül,kütüphane gibi düþünebilirsiniz
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {//bu metot uygulaöada kullanýlacak olan ara katmanlarýn belirlediði metottur.
            //MiddleWare adýyla da bilinir.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //bu middleware routing iþlemini devreye alýr.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
