using FluentValidation;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
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
            services.AddTransient<ITestRepository, TestRepository>();

            services.AddHttpClient<ITestClient, TestClient>(x => x.BaseAddress = new Uri("https://localhost:0000"));
            services.AddHttpClient<ITestEmailClient, TestEmailClient>(x => x.BaseAddress = new Uri("https://localhost:1111"));

            // services.AddMassTransit . . .
            //
            //

            //services.AddTransient<ITestMessageService, TestMessageService>();

            services.AddDbContext<DatabaseDbContext>(options =>
            {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                sqlOptions => sqlOptions.EnableRetryOnFailure());
            });


            return services;

        }
    }
}
