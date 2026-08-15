namespace Day44_CustomMiddleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;

        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Request Started ...");
            Console.WriteLine($"Path : {context.Request.Path}");
            await _next(context);

            Console.WriteLine("Response Finished");
            Console.WriteLine($"Status code : {context.Response.StatusCode}");
        }
    }
}
