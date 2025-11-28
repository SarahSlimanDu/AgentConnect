using Domain.Core.Result;

namespace Domain.Errors
{
    public class AgentErrors
    {
        public static Error NoAvailableAgents() => new Error(
           "AvailableAgents.NotFound", "No Available Agent to handle your request");
    }
}
