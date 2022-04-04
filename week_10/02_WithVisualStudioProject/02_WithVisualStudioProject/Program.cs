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
        //asl�nda asp.net core bir console uygulamas�d�r.
        public static void Main(string[] args)
        {
            //uygulaman�n baslang�c noktas�
            //butun islem burdan baslar
            //asp.net core sunucuyu ayaga kald�r�r
            //bu isi geriye Ihost builder t�r�nden bir deger dondoren 
            //assag�daki cretehostbuilder metodu kullanarak yap�yor
            CreateHostBuilder(args).Build().Run();

            //bir sucu ayaga kalkarken cesitli configurasion ayarlara ihtiyac duyar
            //bu configlerin nerden al�n�cag� belirtilir

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //sunucu startup clas�ndaki konfigurasyonlar� kullanarak ayaga kalk�yor.




                    webBuilder.UseStartup<Startup>();
                });
    }
}
