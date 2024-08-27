using service.Application.Interfaces;
using service.Domain.Requests;

namespace service.Infrastructure.ApiClients
{
    public class TestEmailClient : ITestEmailClient
    {


        public Task<bool> SendEmail(TestEmailRequest request)
        {
            return Task.FromResult(true);
        }


    }
}
