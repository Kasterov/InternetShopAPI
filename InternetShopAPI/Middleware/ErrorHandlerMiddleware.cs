using InternetShopAPI.Extensions;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace InternetShopAPI.Middlware;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;
    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext content)
    {
        try
        {
            await _next(content);
        }
        catch (InvalidDataException ex)
        {
            await content.Response
                .WithStatusCode(Status405MethodNotAllowed)
                .WithJsonContent(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            await content.Response
                .WithStatusCode(Status416RangeNotSatisfiable)
                .WithJsonContent(ex.Message);
        }
        catch(ArgumentException ex)
        {
            await content.Response
                .WithStatusCode(Status400BadRequest)
                .WithJsonContent(ex.Message);
        }
        catch (Exception ex)
        {
            await content.Response
                .WithStatusCode(Status400BadRequest)
                .WithJsonContent(ex.Message);
        }
     }
}
