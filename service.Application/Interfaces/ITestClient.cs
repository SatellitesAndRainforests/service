using service.Domain.Responses;

namespace service.Application.Interfaces
{
    public interface ITestClient
    {
        Task<TestClientResponse> MakeTestApiClientRequest();
    }
}
