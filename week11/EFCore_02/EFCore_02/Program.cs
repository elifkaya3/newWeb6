using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_02
{
    public class Program
    {
        //EFCore ile oluşturacağımız EF projelerinde
        //EF  .netFrameworkte yaptığımız gibi sihirbaz ile
        //EF'i projeye dahil edemeyiz!
        //BUNUN İÇİN KOD YAZMALIYIZ!

        //Yazacağımız kod, context ve entity classlarını
        //oluşturarak modelimizi yaratacak

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
