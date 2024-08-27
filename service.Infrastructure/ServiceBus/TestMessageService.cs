using MassTransit;
using service.Application.Interfaces;
using service.Domain.Models;

namespace service.Infrastructure.ServiceBus
{
    public class TestMessageService : ITestMessageService
    {
        private readonly IBus _bus;

        public TestMessageService(IBus bus)
        {
            _bus = bus; 
        }


        public async Task SendMessage(TestMessage message)
        {
            var endpoint = await _bus.GetSendEndpoint(new Uri("queue:my-message-queue"));
            await endpoint.Send(message);
        }



    }
}
