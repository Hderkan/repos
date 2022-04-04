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
        //aslýnda asp.net core bir console uygulamasýdýr.
        public static void Main(string[] args)
        {
            //uygulamanýn baslangýc noktasý
            //butun islem burdan baslar
            //asp.net core sunucuyu ayaga kaldýrýr
            //bu isi geriye Ihost builder türünden bir deger dondoren 
            //assagýdaki cretehostbuilder metodu kullanarak yapýyor
            CreateHostBuilder(args).Build().Run();

            //bir sucu ayaga kalkarken cesitli configurasion ayarlara ihtiyac duyar
            //bu configlerin nerden alýnýcagý belirtilir

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //sunucu startup clasýndaki konfigurasyonlarý kullanarak ayaga kalkýyor.




                    webBuilder.UseStartup<Startup>();
                });
    }
}
