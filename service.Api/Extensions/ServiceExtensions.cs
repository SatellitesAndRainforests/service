using FluentValidation;
using service.Application.Interfaces;
using service.Application.Mappings;
using service.Application.Services;
using service.Application.Validators;
using service.Domain.Requests;
using service.Infrastructure.ApiClients;
using service.Infrastructure.Repositories;
using service.Infrastructure.ServiceBus;

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

            services.AddHttpClient<ITestClient, TestClient>(x => x.BaseAddress = new Uri("https://localhost:0000"));
            services.AddHttpClient<ITestEmailClient, TestEmailClient>(x => x.BaseAddress = new Uri("https://localhost:1111"));

            // services.AddMassTransit . . .
            //
            //

            //services.AddTransient<ITestMessageService, TestMessageService>();

            return services;

        }
    }
}
