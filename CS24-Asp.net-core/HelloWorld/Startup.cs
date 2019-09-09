using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld
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

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                string html = @"
                            <!DOCTYPE html>
                            <html>
                            <head>
                                <meta charset=""UTF-8"">
                                <title>Trang web đầu tiên</title>
                            </head>
                            <body>
                                <p>Đây là trang web đầu tiên</p>
                            </body>
                            </html>
                ";
                await context.Response.WriteAsync(html);
            });
        }
    }
}
