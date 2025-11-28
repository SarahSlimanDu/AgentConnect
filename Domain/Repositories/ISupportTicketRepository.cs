using Domain.Entities;

namespace Domain.Repositories
{
    public interface ISupportTicketRepository
    {
        Task<SupportTicket> GetTicketByIdAsync(Guid ticketId);
        Task AddAsync(SupportTicket supportTicket);
        void Update(SupportTicket supportTicket);
    }
}
