using System.Net;

namespace KfmmcAppointmentApi.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly ILogger<ExceptionHandlerMiddleware> logger;
        private readonly RequestDelegate next;

        public ExceptionHandlerMiddleware(ILogger<ExceptionHandlerMiddleware> logger,RequestDelegate next)
        {
            this.logger = logger;
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception ex)
            {
                var errorId = Guid.NewGuid();
                //Log this exception 
                logger.LogError(ex, $"{errorId}:{ex.Message}");
                // Return a constom error Responce
                httpContext.Response.StatusCode=(int)HttpStatusCode.InternalServerError;
                httpContext.Response.ContentType = "application/json";
                var error = new
                {
                    Id = errorId,
                    ErrorMessage = "Somethink went wrong! we are loking into resolving this"

                };
               await httpContext.Response.WriteAsJsonAsync(error);
            }

        }
    }
}
