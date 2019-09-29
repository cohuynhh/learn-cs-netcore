using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Middleware
{
    public class CheckAcessMiddleware
    {
        // Lưu middlewware tiếp theo trong Pipeline
        private readonly RequestDelegate _next;                 
        public CheckAcessMiddleware(RequestDelegate next) {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext) {

            Console.WriteLine("Go in CheckAcessMiddleware");



            if (httpContext.Request.Path ==  "/testxxx") {
                await  Task.Run(
                    async () => {
                        string html = "<h1>CAM KHONG DUOC TRUY CAP</h1>";
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