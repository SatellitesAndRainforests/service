using service.Application.Interfaces;
using service.Domain.Entities;

namespace service.Infrastructure.Repositories
{
    public class TestRepository : ITestRepository
    {

        private List<TestEntityObject> _inMemoryCollection;

        public TestRepository()
        {
            _inMemoryCollection = new List<TestEntityObject>
            {
                new TestEntityObject { TestInt = 1, TestString = "test A", TestBool = true },
                new TestEntityObject { TestInt = 2, TestString = "test B", TestBool = true },
            };
        }

        public Task<TestEntityObject?> GetTestAsync()
        {
            var result = _inMemoryCollection.FirstOrDefault();
            return Task.FromResult(result);
        }

    }
}
