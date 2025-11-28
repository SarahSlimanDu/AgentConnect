using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class SupportTicketRepository(AgentConnectDbContext context) : ISupportTicketRepository
    {
        private AgentConnectDbContext _context = context;
        public async Task AddAsync(SupportTicket supportTicket)
        {
            await _context.AddAsync(supportTicket); 
        }

        public async Task<SupportTicket> GetTicketByIdAsync(Guid ticketId)
        {
            return await _context.SupportTickets.SingleAsync(s => s.Id == ticketId);
        }

        public void Update(SupportTicket supportTicket)
        {
            _context.Update(supportTicket);
        }
    }
}
