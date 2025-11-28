using Domain.Core.Result;
using MediatR;


namespace Application.Commands
{
    public record CreateSupportTicketCommand(string subject, string description, Guid userId) :IRequest<Result>;
  
}
