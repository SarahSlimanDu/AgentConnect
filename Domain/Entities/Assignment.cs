
namespace Domain.Entities
{
    public sealed class Assignment 
    {
        public Assignment(Guid supportTicketId, Guid agentId)
        {
            SupportTicketId = supportTicketId;
            AgentId = agentId;
            AssignedOn = DateTime.UtcNow;
        }
        public Guid SupportTicketId { get; private set; }
        public Guid AgentId { get; private set; }
        public DateTime AssignedOn { get; private set; }

        public static Assignment Create(Guid supportTicketId, Guid agentId) 
        { 
            return new Assignment(supportTicketId, agentId);
        
        }
    }
}
