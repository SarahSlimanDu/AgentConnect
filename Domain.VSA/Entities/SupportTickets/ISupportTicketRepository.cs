

namespace Domain.VSA.Entities
{
    public interface ISupportTicketRepository
    {
        Task<SupportTicket> GetTicketByIdAsync(Guid ticketId);
        Task AddAsync(SupportTicket supportTicket);
        void Update(SupportTicket supportTicket);
    }
}
