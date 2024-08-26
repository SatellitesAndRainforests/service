using service.Domain.Entities;

namespace service.Application.Interfaces
{
    public interface ITestRepository
    {
        Task<TestObject?> GetTestAsync();
    }
}
