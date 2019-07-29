using System;
using System.Collections.Generic;
using System.Text;
using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler : Notifiable, IHandler<CreateBoletoSubscriptionCommand>
    {
        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
