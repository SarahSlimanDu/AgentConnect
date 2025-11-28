using Domain.VSA.Entities;
using Domain.VSA.Entities.Agents;
using Infrastructure.VSA.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.VSA.Repositories
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
