using Microsoft.AspNetCore.Builder;

namespace Middleware
{
    public static class MyAppExtensions
    {
         public static IApplicationBuilder UseCheckAccess(this IApplicationBuilder builder)
         {
             return builder.UseMiddleware<CheckAcessMiddleware>();
         }

    }
}
