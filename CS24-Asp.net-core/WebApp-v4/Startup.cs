using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Controller;
using WebApp.Services;
using WebApp.Middleware;
using Microsoft.Extensions.Configuration;
using System.Text;
using WebApp.Options;

namespace WebApp
{ 
    public class Startup
    {
        private IServiceCollection _services;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IListProductName, PhoneName>();               //  đăng ký dịch vụ, đối tượng chỉ tạo một lần (cận thận)
            services.AddTransient<LaptopName, LaptopName>();                    //  đăng ký dịch vụ, tạo mới  mỗi lần  triệu gọi
            services.AddTransient<ProductController, ProductController>();

            services.AddDistributedMemoryCache();
            services.AddSession(cfg => {
                cfg.Cookie.Name = "xuanthulab";             // Đặt tên Sesseon - tên này sử dụng ở Browser (Cookie)
                cfg.IdleTimeout = new TimeSpan(0,60, 0);    // Thời gian tồn tại của Cookie
            });

            _services = services;


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); 
            app.UseSession();

            app.UseCheckAccess();

            var a = app.ApplicationServices.GetService<IConfiguration>();

            app.Map("/Product", appProduct => {

                appProduct.Run(async (context) => {
                    await appProduct.ApplicationServices.GetService<ProductController>().List(context);
                });

            }); 

            

            app.Map("/RequestInfo", app01 => {
                app01.Run(async (context) => {
                    string menu         = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string requestinfo  = RequestProcess.RequestInfo(context.Request).HtmlTag("div", "container");
                    
                    string accessinfo  = ProductController.CountAccessInfo(context).HtmlTag("div", "container");

                    string html         = HtmlHelper.HtmlDocument("Thông tin Request", (menu + accessinfo + requestinfo));
                    await context.Response.WriteAsync(html);
                });
            });
             
            app.Map("/Form", app01 => {
                app01.Run(async (context) => {
                    string menu     = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string formhtml = await RequestProcess.FormProcess(context.Request);
                           formhtml = formhtml.HtmlTag("div", "container");
                    string html     = HtmlHelper.HtmlDocument("Form Post", (menu + formhtml));
                    await context.Response.WriteAsync(html);
                });
            });

            app.Map("/Encoding", app01 => {
                app01.Run(async (context) => {
                    string menu     = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string htmlec   = RequestProcess.Encoding(context.Request).HtmlTag("div", "container");
                    string html     = HtmlHelper.HtmlDocument("Encoding", (menu + htmlec)); 
                    await context.Response.WriteAsync(html);
                });
            });


            app.Map("/Cookies", app01 => {
                app01.Run(async (context) => {
                    string menu     = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string cookies  = RequestProcess.Cookies(context.Request, context.Response).HtmlTag("div", "container");
                     string html    = HtmlHelper.HtmlDocument("Đọc / Ghi Cookies", (menu + cookies));
                    await context.Response.WriteAsync(html);
                });
            });
            

            app.Map("/Json", app01 => {
                app01.Run(async (context) => {
                    string Json  = RequestProcess.GetJson();
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(Json);
                });
            });
            
            app.Map("/allservice", app01 => {
                app01.Run(async (context) => {

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

        app.Map("/ShowOptions", appOptions => {
                appOptions.Run(async (context) => {

                    StringBuilder stb = new StringBuilder();
                    IConfiguration configuration = appOptions.ApplicationServices.GetService<IConfiguration>();

                    var testoptions = configuration.GetSection("TestOptions");
                    var opt_key1    = testoptions["opt_key1"];
                    var k1          = testoptions.GetSection("opt_key2")["k1"];
                    var k2          = configuration["TestOptions:opt_key2:k2"];

                    stb.Append($"   TestOptions.opt_key1:  {opt_key1}\n");
                    stb.Append($"TestOptions.opt_key2.k1:  {k1}\n");
                    stb.Append($"TestOptions.opt_key2.k2:  {k2}\n");


                    var x = configuration.GetSection("TestOptions").Get<TestOptions>();


                    await context.Response.WriteAsync(stb.ToString().HtmlTag("pre"));

                   
                });
            });

            


            app.Run(async (HttpContext context) =>
            {
                string menu     = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(),context.Request);
                string content  = HtmlHelper.HtmlTrangchu();
                string html     = HtmlHelper.HtmlDocument("Trang chủ", menu + content);
                await context.Response.WriteAsync(html);
            }); 
        }
    }
}
