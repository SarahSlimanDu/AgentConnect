using Domain.VSA.Entities.Agents.Enums;

namespace Domain.VSA.Entities
{
    public sealed class Agent 
    {
        public Agent(string name, string email)
        {
            Name = name;
            Email = email;
            MaximumActiveTickets = 2;
            CurrentActiveTickets = 0;
            Status = AgentStatus.Offline;
        }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int MaximumActiveTickets {  get; private set; }
        public int CurrentActiveTickets { get; private set; }
        public AgentStatus Status { get; private set; }

    }
}
