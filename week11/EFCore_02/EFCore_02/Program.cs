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
        //EFCore ile olusturcagýmýz EF projelerinde EF dotnet frameworkte yaptýgýmýz gibisihirbaz ile
        //EF projeye dahil edemeyiz
        //bunun icin core yazmalýyýz.

        // yazacagýmýz code , context ve entity classlarýnýn olusturarak modelimizi yaratýcak.
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
