using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    public interface IStudentRepository
    {
        bool DocumentExists(string Document);
        bool EnailExists(string email);
        void CreateSubscription(Student student);
    }
}