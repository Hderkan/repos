using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_mvs_01
{
    public class Startup
    {
     
        public void ConfigureServices(IServiceCollection services)
        {
            //bu servisi ekleyerek uygulamam�z� mvc mimarisini kullan�cag�n� blirtmis olduk.
            //dolas�yla art�k bu uygulamaya gelen bir request 
            //kars�lanabilir haldedir kars�layacak olan sey controllerd�r.
            //tabiki sonuc olarak html yaratmas�n� istedgimiz icinde viewlarla cal�sacag�m�z� belirtmis olduk.
            //mdul ise bir servise degildir bu y�zden burada onu ekleme gibi birislem yok.

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //gelen requestlar�n rotas� bu middleware sayesinde belirlenecek.
            app.UseRouting();
            
            //bu middleware en onemlilerindendir 
            //endpoint gelen requesti var�s noktas� diye d�s�n�lebilir.
            //yani yap�lan requestin adresi.

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapDefaultControllerRoute();


                //abc.com
                //abc.com/urunler
                //abc.com/urunler/getir
                //abx.com/urunler/getir/5
            });
        }
    }
}
