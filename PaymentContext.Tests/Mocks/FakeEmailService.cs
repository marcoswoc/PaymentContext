using PaymentContext.Domain.Services;

namespace PaymentContext.Tests.Mocks
{
    public class FakeEmailService : IEmailServices
    {
        public void Send(string to, string email, string subject, string body)
        {
            
        }
    }
}