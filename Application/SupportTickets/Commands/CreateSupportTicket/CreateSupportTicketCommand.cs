using Domain.Core.Result;
using MediatR;


namespace Application.SupportTickets.Commands.CreateSupportTicket
{
    public class CreateSupportTicketCommand(string subject, string Description, Guid userId) : IRequest<Result>;
  
}
