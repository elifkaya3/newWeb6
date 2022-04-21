using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Mvc_01
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //bu servisi ekleyerek uygulamamýzýn mvc mimarisini kullanacaðýmýzý belirtmiþ olduk.
            //dolayýsýyla artýk bu uygulamaya gelen bir request karþýlanabilir haldedir.
            //karþýlayack olan þey controller dýr.
            //tabi ki sonuç olarak html yaratmasýný istediðimiz için de viewlerla
            //çalýþacaðýmýzý belirmiþ olduk

            //*model ise 
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //gelen requestlarýn rotasý bu middleware sayesinde belirlenecektir
            //
            app.UseRouting();
            //bu middleware en önemlilerinden biridir.
            //endpoints gelen requestin varýþ noktasý olarak düþünülebilir.
            //yani yapýlan requestin adresi.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //abc.com
                //abc.com/urunler
                //abc.com/urunler/getir
                //abc.com/urunler/getir/5
            });
        }
    }
}
