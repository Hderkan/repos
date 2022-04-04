using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Startup
    {
        //
        public void ConfigureServices(IServiceCollection services)
        {
            //bu uygulamada kulan�l�cak olan serviselerin elirlendigi method
            //service demek belli bir tak�m isleri yapmak icin kodlar�n icindede bulundugu yap�lard�r, modul, kutuphane gibi
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // bu method uygulamada kullan�l�cak olan ara katmanlar�n kbelirtildigi metoddur.
            //ara katman middleware ad�ylada bilinir.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //bu middleware routing islemini devreye al�r.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
               
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
