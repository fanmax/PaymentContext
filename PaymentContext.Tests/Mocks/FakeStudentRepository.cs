using System;
using System.Collections.Generic;
using System.Text;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        public bool DocumentExists(string document)
        {
            if (document == "99999999999")
                return true;

            return false;
        }

        public bool EnailExists(string email)
        {
            if (email == "test@test.com")
                return true;

            return false;
        }

        public void CreateSubscription(Student student)
        {

        }
    }
}
