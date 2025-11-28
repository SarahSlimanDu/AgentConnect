using Application.Commands;
using Domain.Core.Result;
using Domain.Entities;
using Domain.Errors;
using Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Application.CommandHandlers
{
    internal class CreateSupportTicketCommandHandler(ISupportTicketRepository _supportTicketRepository,
        IAgentRepository _agentRepository,
        IValidator<CreateSupportTicketCommand> _validator) : IRequestHandler<CreateSupportTicketCommand, Result>
    {
        public async Task<Result> Handle(CreateSupportTicketCommand request, CancellationToken cancellationToken)
        {
            _validator.Validate(request);

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

            return Result.Success();
        }
    }
}
