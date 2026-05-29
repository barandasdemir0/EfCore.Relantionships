using Microsoft.AspNetCore.Diagnostics;

namespace EfCore.Relantionships;

public class ExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        await httpContext.Response.WriteAsJsonAsync(new
        {
            Message = exception.Message
        });

        return true;
    }
}
