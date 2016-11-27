using CinemaBooking.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CinemaBooking
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Add MVC
            services.AddMvc();

            //Add SQL Lite with EntityFramework
            services.AddEntityFrameworkSqlite().AddDbContext<CinemaContext>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();

            app.Run(context =>
            {
                return context.Response.WriteAsync("Hello from ASP.NET Core!");
            });
        }
    }
}
