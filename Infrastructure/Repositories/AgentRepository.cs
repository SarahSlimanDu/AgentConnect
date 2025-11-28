using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AgentRepository(AgentConnectDbContext context) : IAgentRepository
    {
        private AgentConnectDbContext _context = context;
        
        public async Task<List<Agent>> GetAvailableAgents()
        {
            return await _context.Agents.Where(a => a.CurrentActiveTickets < 2).ToListAsync();
        }
    }
}
