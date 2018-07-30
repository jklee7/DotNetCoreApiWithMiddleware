using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DotNetCoreApiWithMiddleware.Middleware
{
    public class QueryStringsToLowercaseMiddleware
    {
        private readonly RequestDelegate _next;

        public QueryStringsToLowercaseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            Console.WriteLine("Reformatting querystring to lowercase");
            
            var lowercaseQueryString = new QueryString(context.Request.QueryString.ToString().ToLower());
            context.Request.QueryString = lowercaseQueryString;

            // Call the next delegate/middleware in the pipeline
            await _next(context);
        }
    }
}
