using service.Application.Interfaces;
using service.Domain;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Newtonsoft.Json;
using System.Net;
using service.Api.Tests.TestSetup;
using service.Domain.Responses;

namespace service.Api.Tests.Tests
{
    public class TestApiTest
    {
        private readonly Mock<ITestService> _testService;

        public TestApiTest() 
        { 
            _testService = new Mock<ITestService>();
        }


        [Fact]
        public async Task GetTest_ReturnsResultsOkWithTestResponse()
        {
            // Arrange 
            await using var application = new TestApplicationFactory(Xunit =>
            {
                Xunit.AddSingleton(_testService.Object);
            });
            var client = application.CreateClient();

            _testService.Setup(x => x.GetTestAsync()).ReturnsAsync(new TestResponse());

            // Act
            var response = await client.GetAsync("/test");
            var responseContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TestResponse>(responseContent);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(responseContent);
            Assert.IsType<TestResponse>(result);

        }


        [Fact]
        public async Task GetTest_ReturnsInternalServerHttpStatusCodeWhenException()
        {
            // Arrange 
            await using var application = new TestApplicationFactory(Xunit =>
            {
                Xunit.AddSingleton(_testService.Object);
            });
            var client = application.CreateClient();

            _testService.Setup(x => x.GetTestAsync()).Throws<Exception>();

            // Act
            var response = await client.GetAsync("/test");

            // Assert
            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);

        }


    }
}
