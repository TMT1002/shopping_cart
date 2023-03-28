using static System.Net.Mime.MediaTypeNames;

namespace Web.Middleware
{
    public class testMiddleware
    {
        private readonly RequestDelegate _next;
        public testMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                throw new BadHttpRequestException("huuh",400);
                await _next(context);
            }
            catch (BadHttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
