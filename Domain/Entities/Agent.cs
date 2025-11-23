
using Domain.Enums;

namespace Domain.Entities
{
    public sealed class Agent : BaseEntity<Guid>
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
