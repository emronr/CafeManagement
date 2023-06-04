using CafeManagement.API.Middlewares;

namespace CafeManagement.API.Extensions;

public static class RequestLoggingMiddlewareExtension
{
   public static IApplicationBuilder UseRequestLogAndExceptionHandle(this IApplicationBuilder app)
   {
      return app.UseMiddleware<RequestLoggingMiddleware>();
   }
}