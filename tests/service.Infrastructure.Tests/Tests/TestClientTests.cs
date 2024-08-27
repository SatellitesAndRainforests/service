using service.Application.Interfaces;
using service.Domain.Responses;
using service.Infrastructure.ApiClients;

namespace service.Infrastructure.Tests.Tests
{
    public class TestClientTests
    {

        public readonly ITestClient _testClient = new TestClient();


        [Fact]
        public async Task Test()
        {
            // Arrange

            // Act 
            var result = await _testClient.MakeTestApiClientRequest();

            // Assert
            Assert.IsType<TestClientResponse>(result);

        }

    }
}
