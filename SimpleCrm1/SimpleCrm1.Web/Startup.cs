using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleCrm1.SqlDbServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm1.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get };

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); // turns on all MVC middleware
            services.AddSingleton<IGreeter, ConfigurationGreeterConfigFile>();
            services.AddScoped<ICustomerData, SqlCustomerData>();

            services.AddDbContext<SimpleCrmDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SimpleCrmConnection"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IGreeter greeter)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(new ExceptionHandlerOptions
                {
                    ExceptionHandler = context =>
                        context.Response.WriteAsync("oops!")
                });
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();  // turns on  MVC routing (basic settings)
                endpoints.MapControllerRoute(
                    "default", 
                    "{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.Run(ctx => ctx.Response.WriteAsync("Not found"));
        }
    }
}
