using service.Domain.Models;

namespace service.Application.Interfaces
{
    public interface ITestMessageService
    {
        Task SendMessage(TestMessage message);
    }
}
