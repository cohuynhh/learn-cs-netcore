using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp02
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            foreach (var item in services)
            {
                Console.WriteLine(item.ServiceType.Name.ToString());
            }
        }

        public void RequestInfo(IApplicationBuilder app) 
        {
            app.Run(async (context) => {
                await context.Response.WriteAsync(RequestInfomation.Infopage(context.Request));
            });
        }

        async Task Abc(HttpContext context) 
        {
            await context.Response.WriteAsync("abc");
        }

        Task Xtz(HttpContext context) 
        {
            return context.Response.WriteAsync("Xyz");
        }
        

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.Map("/RequestInfo", RequestInfo);

            app.Map("/Test", (app1) => {
                app1.Run(async (context) => {
                    string content  = context.Request.Path;
                    await context.Response.WriteAsync(content);
                });
            });
  

            app.Run(async (context) =>
            {
                string html = @"Test";
                await context.Response.WriteAsync(html);
            });



            
        }
    }
}
