using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kicksharp.Web.Config
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            FeatureConvention featureConvention = new FeatureConvention();

            services
                .AddRouting(options => options.LowercaseUrls = true)
                .AddMvc(options => options.Conventions.Add(featureConvention))
                .AddRazorOptions(featureConvention.RazorOptions);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
//            if (env.IsDevelopment())
//            {
                app.UseDeveloperExceptionPage();
//            }
//            else
//            {
//                app.UseExceptionHandler("/Pages/Error/Index.cshtml");
//            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
