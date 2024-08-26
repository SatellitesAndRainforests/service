using service.Api.Extensions;
using service.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureApplicationServices(builder.Configuration);

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapServiceEndpoints();
app.MapHealthChecks("/heatlh");

app.Run();

public partial class Program { }
