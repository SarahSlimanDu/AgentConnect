using Domain.VSA.Entities;

namespace Domain.DomainEvents
{
    internal class SupportTicketCreatedDomainEvent
    {
        internal SupportTicketCreatedDomainEvent(SupportTicket supportTicket) => SupportTicket = supportTicket;

        public SupportTicket SupportTicket { get; }
    }
}
