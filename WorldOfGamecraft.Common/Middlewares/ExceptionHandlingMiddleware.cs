using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Serilog;
using System.Text.Json.Nodes;

namespace WorldOfGamecraft.Common.Middlewares;
public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            // log the error
            Log.Error(exception, "Error during executing {Context}", context.Request.Path.Value);
            var response = context.Response;
            response.ContentType = "application/json";

            var message = JsonConvert.SerializeObject(new { exception.Message });
            await response.WriteAsync(message);
        }
    }
}
