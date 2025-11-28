using Domain.VSA.Entities.SupportTickets.Enums;

namespace Domain.VSA.Entities
{
    public sealed class SupportTicket
    {
        public SupportTicket(Guid id, Guid userId, string subject, string description, SupportTicketStatus status)
        {
            UserId = userId;
            Subject = subject;
            Description = description;
            Status = status;
        }
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public string Subject { get; private set; }
        public string Description { get; private set; }
        public SupportTicketStatus Status { get; private set; }
        public DateTime? DeletedOn { get; }
        public bool Deleted { get; }

        public static SupportTicket Create(Guid userId, string subject, string description)
        {
            return new SupportTicket(Guid.NewGuid(), userId, subject, description, SupportTicketStatus.New);
        }

        public void ChangeStatus(SupportTicketStatus status)
        {
            this.Status = status;
        }
    }
}
