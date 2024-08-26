using FluentValidation;
using service.Application.Interfaces;
using service.Application.Mappings;
using service.Application.Services;
using service.Application.Validators;
using service.Domain.Requests;
using service.Infrastructure.Repositories;

namespace service.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IValidator<TestRequest>, TestRequestValidator>();

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<ITestService, TestService>();
            services.AddSingleton<ITestRepository, TestRepository>();

            return services;

        }
    }
}
