using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SquirtCMS.Framework.Foundation
{
    public static class CoreExtensions
    {
        public static IServiceCollection AddSquirtApplication(this IServiceCollection services)
        {
            return services
            .AddScoped<SquirtCMS.Framework.Foundation.Services.IApplicationService, SquirtCMS.Framework.Foundation.Services.ApplicationService>();
        }
    }
}