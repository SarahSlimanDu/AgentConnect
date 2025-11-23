using Domain.Core.Abstractions;
using Domain.Enums;

namespace Domain.Entities
{
    public sealed class SupportTicket : BaseEntity<Guid>, ISoftDeletableEntity
    {
        public SupportTicket(Guid userId, string subject, string description,SupportTicketStatus status)
        {
            UserId = userId;
            Subject = subject;
            Description = description;
            Status = status;
        }
        public Guid UserId { get; private set; }
        public string Subject { get; private set; }
        public string Description { get; private set; }
        public SupportTicketStatus Status { get; private set; }
        public DateTime? DeletedOn { get; }
        public bool Deleted { get; }

        public static SupportTicket Create(Guid userId, string subject, string description)
        {
            return new SupportTicket(userId, subject, description, SupportTicketStatus.New);
        }
    }
}
