using Microsoft.AspNetCore.Builder;

namespace WebApp.Middleware
{
    public static class MyAppExtensions
    {
         public static IApplicationBuilder UseCheckAccess(this IApplicationBuilder builder) 
         {
             return builder.UseMiddleware<CheckAcessMiddleware>();
         }
         
    }
}