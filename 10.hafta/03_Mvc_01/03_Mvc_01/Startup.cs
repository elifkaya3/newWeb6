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
            //bu servisi ekleyerek uygulamam�z�n mvc mimarisini kullanaca��m�z� belirtmi� olduk.
            //dolay�s�yla art�k bu uygulamaya gelen bir request kar��lanabilir haldedir.
            //kar��layack olan �ey controller d�r.
            //tabi ki sonu� olarak html yaratmas�n� istedi�imiz i�in de viewlerla
            //�al��aca��m�z� belirmi� olduk

            //*model ise 
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //gelen requestlar�n rotas� bu middleware sayesinde belirlenecektir
            //
            app.UseRouting();
            //bu middleware en �nemlilerinden biridir.
            //endpoints gelen requestin var�� noktas� olarak d���n�lebilir.
            //yani yap�lan requestin adresi.
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
