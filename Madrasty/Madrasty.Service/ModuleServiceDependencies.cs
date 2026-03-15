using Madrasty.Service.Abstracts;
using Madrasty.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Madrasty.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
            => services.AddTransient<IStudentService, StudentService>()
            .AddTransient<IDepartmentService, DepartmentService>();
    }
}
