using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ConsoleApp1
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                return context.Response.WriteAsync($"Hello from Macaw through ASP.NET Core, time is: {DateTime.UtcNow}!");
            });
        }
    }
}