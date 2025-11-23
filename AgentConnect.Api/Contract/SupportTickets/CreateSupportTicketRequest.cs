namespace AgentConnect.Api.Contract.SupportTickets
{
    public record CreateSupportTicketRequest
    {
        public required string Subject {  get; init; }
        public required string Description {  get; init; }
        public required Guid RequestedUserId {  get; init; }
    }
}
