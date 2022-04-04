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
            //bu servisi ekleyerek uygulamamýzý mvc mimarisini kullanýcagýný blirtmis olduk.
            //dolasýyla artýk bu uygulamaya gelen bir request 
            //karsýlanabilir haldedir karsýlayacak olan sey controllerdýr.
            //tabiki sonuc olarak html yaratmasýný istedgimiz icinde viewlarla calýsacagýmýzý belirtmis olduk.
            //mdul ise bir servise degildir bu yüzden burada onu ekleme gibi birislem yok.

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //gelen requestlarýn rotasý bu middleware sayesinde belirlenecek.
            app.UseRouting();
            
            //bu middleware en onemlilerindendir 
            //endpoint gelen requesti varýs noktasý diye düsünülebilir.
            //yani yapýlan requestin adresi.

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
