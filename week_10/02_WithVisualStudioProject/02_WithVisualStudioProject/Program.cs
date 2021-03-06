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
        //aslında asp.net core bir console uygulamasıdır.
        public static void Main(string[] args)
        {
            //uygulamanın baslangıc noktası
            //butun islem burdan baslar
            //asp.net core sunucuyu ayaga kaldırır
            //bu isi geriye Ihost builder türünden bir deger dondoren 
            //assagıdaki cretehostbuilder metodu kullanarak yapıyor
            CreateHostBuilder(args).Build().Run();

            //bir sucu ayaga kalkarken cesitli configurasion ayarlara ihtiyac duyar
            //bu configlerin nerden alınıcagı belirtilir

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //sunucu startup clasındaki konfigurasyonları kullanarak ayaga kalkıyor.




                    webBuilder.UseStartup<Startup>();
                });
    }
}
