using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Program
    {

        /*aslýnda Asp.Net core uygulamalarý bir console uygulamasýdýr.*/
        public static void Main(string[] args)
        {
            //burasý uygulamanýn baþlangýc noktasýdýr.
            //bütün hikaye burada baþlýyor.
            //Asp.NEt Core sunucyu ayaða kaldýrýlýyor.
            //bu iþi geriye IHostBuilder türünden deðer döndüren
            //aþaðýdaki crateHosTBuilder metodunu kullanarak yapýyor.
            CreateHostBuilder(args).Build().Run();
        }
        //bir sunucu ayaða kalkarken çeþitli konfigrasyonlar
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //sunuvu startup classýndaki konfigrasyonalr kullanarak ayaða kaldýrýlýyor
                    webBuilder.UseStartup<Startup>();
                });
           
    }
}
