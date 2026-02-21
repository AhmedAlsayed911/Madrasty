using Madrasty.Infrastructure.Abstracts;
using Madrasty.Infrastructure.InfrastructureBases;
using Madrasty.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Madrasty.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
            => services.AddTransient<IStudentRepostitory, StudentRepostitory>()
                .AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
    }
}
