using Domain.Core.Events;
using Domain.Entities;

namespace Domain.DomainEvents
{
    internal class SupportTicketCreatedDomainEvent : IDomainEvent
    {
        internal SupportTicketCreatedDomainEvent(SupportTicket supportTicket) => SupportTicket = supportTicket;

        public SupportTicket SupportTicket { get; }
    }
}
