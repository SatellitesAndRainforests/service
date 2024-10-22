using Domain.Entities;
using service.Domain.Responses;

namespace service.Application.Interfaces
{
    public interface ITestService
    {
        Task<TestResponse> GetTestAsync();
        Task<Entity1?> GetEntity1Async();
    }
}
