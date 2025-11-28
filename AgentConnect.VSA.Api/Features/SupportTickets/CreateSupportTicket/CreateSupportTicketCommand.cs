using Domain.VSA.Core.Result;
using MediatR;


namespace Application.SupportTickets.Commands.CreateSupportTicket
{
    public record CreateSupportTicketCommand(string subject, string Description, Guid userId) : IRequest<Result>;
  
}
