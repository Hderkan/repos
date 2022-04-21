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
        //EFCore ile olusturcag�m�z EF projelerinde EF dotnet frameworkte yapt�g�m�z gibisihirbaz ile
        //EF projeye dahil edemeyiz
        //bunun icin core yazmal�y�z.

        // yazacag�m�z code , context ve entity classlar�n�n olusturarak modelimizi yarat�cak.
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
