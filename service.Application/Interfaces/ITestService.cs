using service.Domain.Responses;

namespace service.Application.Interfaces
{
    public interface ITestService
    {
        Task<TestResponse> GetTestAsync();
    }
}
