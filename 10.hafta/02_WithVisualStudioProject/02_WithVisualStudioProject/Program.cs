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

        /*asl�nda Asp.Net core uygulamalar� bir console uygulamas�d�r.*/
        public static void Main(string[] args)
        {
            //buras� uygulaman�n ba�lang�c noktas�d�r.
            //b�t�n hikaye burada ba�l�yor.
            //Asp.NEt Core sunucyu aya�a kald�r�l�yor.
            //bu i�i geriye IHostBuilder t�r�nden de�er d�nd�ren
            //a�a��daki crateHosTBuilder metodunu kullanarak yap�yor.
            CreateHostBuilder(args).Build().Run();
        }
        //bir sunucu aya�a kalkarken �e�itli konfigrasyonlar
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //sunuvu startup class�ndaki konfigrasyonalr kullanarak aya�a kald�r�l�yor
                    webBuilder.UseStartup<Startup>();
                });
           
    }
}
