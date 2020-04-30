using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApp.Controller;
using WebApp.Services;

namespace WebApp
{
    public class Startup
    {
        IServiceCollection  _services;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IListProductName, PhoneName>();          //  đăng ký dịch vụ, đối tượng chỉ tạo một lần (cận thận)
            services.AddTransient<LaptopName, LaptopName>();               //  đăng ký dịch vụ, tạo mới  mỗi lần  triệu gọi
            services.AddTransient<ProductController, ProductController>();

            _services = services;


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    string menu     = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(),context.Request);
                    string content  = HtmlHelper.HtmlTrangchu();
                    string html     = HtmlHelper.HtmlDocument("Trang chủ", menu + content);
                    await  context.Response.WriteAsync(html);
                });

                endpoints.MapGet("/RequestInfo", async (context) => {
                    string menu         = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string requestinfo  = RequestProcess.RequestInfo(context.Request).HtmlTag("div", "container");
                    string html         = HtmlHelper.HtmlDocument("Thông tin Request", (menu + requestinfo));
                    await context.Response.WriteAsync(html);
                });

                
                endpoints.Map("/Form", async (context) => {
                    string menu     = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string formhtml = await RequestProcess.FormProcess(context.Request);
                           formhtml = formhtml.HtmlTag("div", "container");
                    string html     = HtmlHelper.HtmlDocument("Form Post", (menu + formhtml));
                    await context.Response.WriteAsync(html);
                });

                endpoints.MapGet("/Encoding", async (context) => {
                    string menu     = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string htmlec   = RequestProcess.Encoding(context.Request).HtmlTag("div", "container");
                    string html     = HtmlHelper.HtmlDocument("Encoding", (menu + htmlec));
                    await context.Response.WriteAsync(html);
                }); 

                endpoints.MapGet("/Cookies/{*action}", async (context) => {
                    string menu     = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string cookies  = RequestProcess.Cookies(context.Request, context.Response).HtmlTag("div", "container");
                    string html    = HtmlHelper.HtmlDocument("Đọc / Ghi Cookies", (menu + cookies));
                    await context.Response.WriteAsync(html);
                }); 

                endpoints.MapGet("/Json", async (context) => {
                    string Json  = RequestProcess.GetJson();
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(Json);
                    
                }); 

                endpoints.MapGet("/Product", async (context) => {
                    await context.RequestServices.GetService<ProductController>().List(context);
                    
                }); 

                endpoints.MapGet("/allservice", async (context) => {
                    var stringBuilder = new StringBuilder();
                    stringBuilder.Append("<tr><th>Tên</th><th>Lifetime</th><th>Tên đầy đủ</th></tr>");
                    foreach (var service in _services)
                    {
                        string tr = service.ServiceType.Name.ToString().HtmlTag("td") +
                        service.Lifetime.ToString().HtmlTag("td") +
                        service.ServiceType.FullName.HtmlTag("td");
                        stringBuilder.Append(tr.HtmlTag("tr"));
                    }

                    string htmlallservice  = stringBuilder.ToString().HtmlTag("table", "table table-bordered table-sm");
                    string html           = HtmlHelper.HtmlDocument("Các dịch vụ", (htmlallservice));

                    await context.Response.WriteAsync(html);
                });


                
            


            });





 




           
        

        }
    }
}
