using Blog_Api.Business.Exceptions.Category;
using Blog_Api.Business.Exceptions.Commons;
using Microsoft.AspNetCore.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Blog_Api.API.Helpers
{
    public static class CustomHandlerException
    {
        public static void UseCustomExceptionHandler(this WebApplication app)
        {
            app.UseExceptionHandler(exceptionHandlerApp =>
            {
                exceptionHandlerApp.Run(async context =>
                {
                    var feature = context.Features.Get<IExceptionHandlerFeature>();
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    if(feature?.Error is IBaseException ex)
                    {
                        await context.Response.WriteAsJsonAsync(new
                        {
                            StatuseCode=ex.StatusCode,
                            ErrorMessage=ex.ErrorMessage
                        });
                    }
                    else if(feature?.Error is CategoryException )
                    {
                        await context.Response.WriteAsJsonAsync(new
                        {
                            StatuseCode = StatusCodes.Status404NotFound,
                            ErrorMessage = feature?.Error.ToString()
                        });
                    }



                    

                    if (feature?.Path == "/")
                    {
                        await context.Response.WriteAsync(" Page: Home.");
                    }
                });
            });
        }
    }
}
