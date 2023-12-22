using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using PestKitOnionAB104.Application.Validators;
using System.Reflection;

namespace PestKitOnionAB104.Application.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(CategoryProfile));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddFluentValidation(options => options.RegisterValidatorsFromAssemblyContaining(typeof(DepartmentCreateDtoValidator)));

            return services;
        }
    }
}
