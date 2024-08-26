using FluentValidation;
using FluentValidation.Results;
using service.Domain.Requests;
using Microsoft.AspNetCore.Mvc;
using service.Application.Interfaces;

namespace service.Api.Extensions
{
    public static class ServiceEndpointsExtension
    {
        public static void MapServiceEndpoints(this WebApplication app)
        {

            app.MapGet("/test", async ( ITestService testService) =>
            {
                return Results.Ok(await testService.GetTestAsync());
            });


            //app.MapPut("test-add", async (
            //    [FromBody] TestRequest request,
            //    IValidator<TestRequest> validator,
            //    ITestService testService) =>
            //{
            //    ValidationResult validationResult = await validator.ValidateAsync(request);

            //    if (!validationResult.IsValid) return Results.ValidationProblem(validationResult.ToDictionary());

            //    TestResponse member = await testService.SaveAsync(request);

            //    return Results.Ok(member);

            //});

        }
    }
}

