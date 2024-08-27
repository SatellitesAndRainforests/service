using service.Domain.Requests;

namespace service.Application.Interfaces
{
    public interface ITestEmailClient
    {
        Task<bool> SendEmail(TestEmailRequest request);
    }
}
