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
            //bu uygulamada kulanýlýcak olan serviselerin elirlendigi method
            //service demek belli bir takým isleri yapmak icin kodlarýn icindede bulundugu yapýlardýr, modul, kutuphane gibi
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // bu method uygulamada kullanýlýcak olan ara katmanlarýn kbelirtildigi metoddur.
            //ara katman middleware adýylada bilinir.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //bu middleware routing islemini devreye alýr.
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
