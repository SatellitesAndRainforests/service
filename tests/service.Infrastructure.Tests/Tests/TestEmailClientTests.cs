using service.Application.Interfaces;
using service.Domain.Requests;
using service.Infrastructure.ApiClients;

namespace service.Infrastructure.Tests.Tests
{
    public class TestEmailClientTests
    {

        public readonly ITestEmailClient _testEmailClient = new TestEmailClient();


        [Fact]
        public async Task Test()
        {
            // Arrange

            // Act 
            var result = await _testEmailClient.SendEmail(new TestEmailRequest());

            // Assert
            Assert.IsType<bool>(result);

        }


    }
}
