using Domain.VSA.Core.Result;

namespace Domain.VSA.Entities.Agents
{
    public class AgentErrors
    {
        public static Error NoAvailableAgents() => new Error(
           "AvailableAgents.NotFound", "No Available Agent to handle your request");
    }
}
