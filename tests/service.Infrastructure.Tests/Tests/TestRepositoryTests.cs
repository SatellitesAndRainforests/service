using service.Application.Interfaces;
using service.Domain.Entities;
using service.Infrastructure.Repositories;

namespace service.Infrastructure.Tests.Tests
{
    public class TestRepositoryTests
    {
        public readonly ITestRepository _testRepository = new TestRepository();


        [Fact]
        public async Task Test()
        {
            // Arrange
            
            // Act 
            var result = await _testRepository.GetTestAsync();

            // Assert
            Assert.IsType<TestEntityObject>(result);


        }



    }
}
