using Domain.Core.Result;
using MediatR;


namespace Application.Commands
{
    public class CreateSupportTicketCommand
        (string subject, string Description, Guid userId) :IRequest<Result>;
  
}
