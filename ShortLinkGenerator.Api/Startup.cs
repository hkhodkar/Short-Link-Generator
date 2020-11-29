using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Commands;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Queries;
using ShortLinkGenerator.ApplicationServices.Services.Commands;
using ShortLinkGenerator.ApplicationServices.Services.Queries;
using ShortLinkGenerator.DomainContracts.Interfaces.Commamds;
using ShortLinkGenerator.DomainContracts.Interfaces.Queries;
using ShortLinkGenerator.DomainServices.Services.Commands;
using ShortLinkGenerator.DomainServices.Services.Queries;
using ShortLinkGenerator.EF.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortLinkGenerator.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<URLContext>(option => option.UseSqlServer(Configuration["ConnectionStrings:Default"]));

            services.AddScoped<IUrlQueryService, UrlQueryService>();
            services.AddScoped<IUrlCommandService, UrlCommandService>();
            services.AddTransient<IUrlQueryRepository, UrlQueryRepository>();
            services.AddTransient<IUrlCommandRepository, UrlCommandRepository>();

            services.AddScoped<IUrlVisitorsCounterQueryService, UrlVisitorsCounterQueryService>();
            services.AddScoped<IUrlVisitorsCounterCommandService, UrlVisitorsCounterCommandService>();
            services.AddScoped<IUrlVisitorsCounterQueryRepository, UrlVisitorsCounterQueryRepository>();
            services.AddScoped<IUrlVisitorsCounterCommandRepository, UrlVisitorsCounterCommandRepository>();





            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Link Generator API",
                    Description = "A short link generator in ASP.NET Core Web API",
                    Contact = new OpenApiContact
                    {
                        Name = "hatef khodkar",
                        Email = "hatef.khodkar@hotmail.com",
                    },
                });
            });
            #endregion
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            #region Swagger
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });

            #endregion

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
