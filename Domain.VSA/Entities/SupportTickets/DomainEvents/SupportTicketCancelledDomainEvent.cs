using Domain.Entities;

namespace Domain.DomainEvents
{
    internal class SupportTicketCancelledDomainEvent
    {
        public SupportTicketCancelledDomainEvent(SupportTicket supportTicket) => SupportTicket = supportTicket;
        public SupportTicket SupportTicket { get; }
    }
}
