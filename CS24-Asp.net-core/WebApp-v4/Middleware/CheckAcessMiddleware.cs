using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApp.Middleware
{
    public class CheckAcessMiddleware
    {
        private readonly RequestDelegate _next;                 // Lưu middlewware tiếp theo trong Pipeline
        public CheckAcessMiddleware(RequestDelegate next) {    
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext) {

            Console.WriteLine("Go in CheckAcessMiddleware");

            if (httpContext.Request.Path ==  "/testxxx") {
                await  Task.Run(
                    async () => {

                        string html = HtmlHelper.HtmlDocument("CẤM", "Không được truy cập".HtmlTag("h1", "display-4 text-danger"));
                        httpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
                        await httpContext.Response.WriteAsync(html);
                    }
                );
                // Không gọi Middleware tiếp theo, httpContext.Response đã đủ thông tin trả về cho Client
            }
            else
            {
                // Thiết lập Header cho HttpResponse
                httpContext.Response.Headers.Add("throughCheckAcessMiddleware", new[] { DateTime.Now.ToString()});

                // Chuyển Middleware tiếp theo trong pipeline
                await _next(httpContext);   
            }
            
         }
    }
}