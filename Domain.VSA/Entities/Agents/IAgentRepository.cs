

namespace Domain.VSA.Entities.Agents
{
    public interface IAgentRepository
    {
        Task<List<Agent>> GetAvailableAgents();
    }
}
