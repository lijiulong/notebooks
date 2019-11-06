using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learning_dotnet_core_web_api.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace learning_dotnet_core_web_api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ActionFilter));
                options.Filters.Add(typeof(AsyncActionFilter));
                options.Filters.Add(typeof(AuthorizationFilter));
                options.Filters.Add(typeof(AsyncAuthorizationFilter));
                options.Filters.Add(typeof(ExceptionFilter));
                options.Filters.Add(typeof(AsyncExceptionFilter));
                options.Filters.Add(typeof(ResourceFilter));
                options.Filters.Add(typeof(AsyncResourceFilter));
                options.Filters.Add(typeof(ResultFilter));
                options.Filters.Add(typeof(AsyncResultFilter));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
