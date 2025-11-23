

using Domain.Entities;

namespace Domain.Repositories
{
    public interface IAgentRepository
    {
        Task<List<Agent>> GetAvailableAgents();
    }
}
