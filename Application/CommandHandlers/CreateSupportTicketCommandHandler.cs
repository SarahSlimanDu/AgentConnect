using Application.Commands;
using Domain.Core.Result;
using Domain.Entities;
using Domain.Errors;
using Domain.Externals;
using Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Application.CommandHandlers
{
    internal class CreateSupportTicketCommandHandler(ISupportTicketRepository _supportTicketRepository,
        IAgentRepository _agentRepository,
        IValidator<CreateSupportTicketCommand> _validator,
        INotificationService _notification) : IRequestHandler<CreateSupportTicketCommand, Result>
    {
        public async Task<Result> Handle(CreateSupportTicketCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                return Result.Failure(new Error("Validation.Error", "The request failed with validation error"));
            }

            //check if we have available agent to handle the ticket
            var availableAgents = await _agentRepository.GetAvailableAgents();
         
            //if no available agent (use case rule) will return error
            if (!availableAgents.Any())
            {
                return Result.Failure(AgentErrors.NoAvailableAgents());
            }

            var supportTicket = SupportTicket.Create(request.userId, request.subject, request.description);
            await _supportTicketRepository.AddAsync(supportTicket);

            //send Notification to the availabe agents
            await _notification.SendNotification();

            return Result.Success();
        }
    }
}
