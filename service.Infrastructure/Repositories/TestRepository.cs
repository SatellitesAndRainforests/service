using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using service.Application.Interfaces;
using service.Domain.Entities;

namespace service.Infrastructure.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly DatabaseDbContext _context;

        private List<TestEntityObject> _inMemoryCollection;

        public TestRepository(DatabaseDbContext dbContext)
        {
            _context = dbContext;

            _inMemoryCollection = new List<TestEntityObject>
            {
                new TestEntityObject { TestInt = 1, TestString = "test A", TestBool = true },
                new TestEntityObject { TestInt = 2, TestString = "test B", TestBool = true },
            };
        }

        public Task<TestEntityObject?> GetTestAsync()
        {
            var result = _inMemoryCollection.FirstOrDefault(x => x.TestString == "test B");
            return Task.FromResult(result);
        }

        public async Task<Entity1?> GetEntity1Async()
        {
            var result = await _context.Entity1.FirstOrDefaultAsync(x => x.Id > 0);
            return result;
        }

    }
}
