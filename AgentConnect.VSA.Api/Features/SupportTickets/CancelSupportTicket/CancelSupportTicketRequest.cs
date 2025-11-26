namespace AgentConnect.VSA.Api.Contract.SupportTickets
{
    public record CancelSupportTicketRequest
    {
        public Guid UserId { get; init; }
        public Guid TicketId { get; init; }
        public required string Reason { get; init; }
    }
}
