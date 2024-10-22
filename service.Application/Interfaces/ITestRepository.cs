using Domain.Entities;
using service.Domain.Entities;

namespace service.Application.Interfaces
{
    public interface ITestRepository
    {
        Task<TestEntityObject?> GetTestAsync();
        Task<Entity1?> GetEntity1Async();
    }
}
