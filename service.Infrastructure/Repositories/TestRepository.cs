using service.Application.Interfaces;
using service.Domain.Entities;

namespace service.Infrastructure.Repositories
{
    public class TestRepository : ITestRepository
    {

        private List<TestObject> _inMemoryCollection;

        public TestRepository()
        {
            _inMemoryCollection = new List<TestObject>
            {
                new TestObject { TestInt = 1, TestString = "test A", TestBool = true },
                new TestObject { TestInt = 2, TestString = "test B", TestBool = true },
            };
        }

        public Task<TestObject?> GetTestAsync()
        {
            var result = _inMemoryCollection.FirstOrDefault();
            return Task.FromResult(result);
        }

    }
}
