using Domain.Entities;

namespace Domain.DomainEvents
{
    internal class SupportTicketAcceptedDomainEvent
    {
        public SupportTicketAcceptedDomainEvent(SupportTicket supportTicket) => SupportTicket = supportTicket;

        public SupportTicket SupportTicket { get;}
      
    }
}
