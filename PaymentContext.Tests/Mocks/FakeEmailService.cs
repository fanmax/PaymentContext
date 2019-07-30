using System;
using System.Collections.Generic;
using System.Text;
using PaymentContext.Domain.Services;

namespace PaymentContext.Tests.Mocks
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string email, string subject, string body)
        {
            
        }
    }
}
