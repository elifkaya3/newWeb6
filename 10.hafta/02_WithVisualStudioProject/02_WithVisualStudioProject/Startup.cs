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
            //bu uygulamada kullan�lacak olan servislerin belirlendi�i metottur.
            //Service demek belli bi tak�m i�leri yapmak kodlar�n i�inde bulundu�u yap�lard�r.
            //mod�l,k�t�phane gibi d���nebilirsiniz
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {//bu metot uygula�ada kullan�lacak olan ara katmanlar�n belirledi�i metottur.
            //MiddleWare ad�yla da bilinir.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //bu middleware routing i�lemini devreye al�r.
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
