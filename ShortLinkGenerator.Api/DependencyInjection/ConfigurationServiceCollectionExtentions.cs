using ShortLinkGenerator.ApplicationContracts.Interfaces.Commands;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Queries;
using ShortLinkGenerator.ApplicationServices.Services.Commands;
using ShortLinkGenerator.ApplicationServices.Services.Queries;
using ShortLinkGenerator.DomainContracts.Interfaces.Commamds;
using ShortLinkGenerator.DomainContracts.Interfaces.Queries;
using ShortLinkGenerator.DomainServices.Services.Commands;
using ShortLinkGenerator.DomainServices.Services.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigurationServiceCollectionExtentions
    {
        public static IServiceCollection AddUrlServices(this IServiceCollection services)
        {
            services.AddScoped<IUrlQueryService, UrlQueryService>();
            services.AddScoped<IUrlCommandService, UrlCommandService>();
            services.AddTransient<IUrlQueryRepository, UrlQueryRepository>();
            services.AddTransient<IUrlCommandRepository, UrlCommandRepository>();

            return services;
        }  
        
        public static IServiceCollection AddUrlUrlVisitorsCounterServices(this IServiceCollection services)
        {

            services.AddScoped<IUrlVisitorsCounterQueryService, UrlVisitorsCounterQueryService>();
            services.AddScoped<IUrlVisitorsCounterCommandService, UrlVisitorsCounterCommandService>();
            services.AddScoped<IUrlVisitorsCounterQueryRepository, UrlVisitorsCounterQueryRepository>();
            services.AddScoped<IUrlVisitorsCounterCommandRepository, UrlVisitorsCounterCommandRepository>();

            return services;
        }
    }
}
