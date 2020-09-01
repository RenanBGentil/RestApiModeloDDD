using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Info = Microsoft.OpenApi.Models.OpenApiInfo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System;

namespace RestApiModeloDDD.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddMvc();

            services.AddControllers();

            services.AddApiVersioning
                (
                cfg =>
                {
                    cfg.ReportApiVersions = true;
                    cfg.AssumeDefaultVersionWhenUnspecified = true;
                    cfg.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                }
                );

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("RestApiModeloDDD", new OpenApiInfo
                {
                    Title = "NerdStore Enterprise Carrinho API",
                    Description = "Esta API faz parte do curso .Net Core Enterprise Applications.",
                    Contact = new OpenApiContact() { Name = "Renan Borges Gentil", Email = "renanbgentil@gmail.com" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

    

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/RestApiModeloDDD/swagger.json", "RestApiModeloDDD");
            });
        }
    }
}
