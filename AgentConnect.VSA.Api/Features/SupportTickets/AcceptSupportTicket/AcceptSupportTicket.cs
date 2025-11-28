using Domain.VSA.Core.Result;
using Domain.VSA.Entities;
using Domain.VSA.Entities.Assignments;
using Domain.VSA.Entities.SupportTickets.Enums;
using FluentValidation;
using MediatR;

namespace AgentConnect.VSA.Api.Features.SupportTickets.AcceptSupportTicket
{
    public class AcceptSupportTicket 
    {
       
        public record AcceptSupportTicketCommand(Guid ticketId, Guid agentId)
       : IRequest<Result>;


        internal class AcceptSupportTicketValidator : AbstractValidator<AcceptSupportTicketCommand>
        {
            public AcceptSupportTicketValidator()
            {
                RuleFor(x => x.ticketId)
              .NotEmpty().WithMessage("ticket Id Should not be empty. ");
            }
        }

        public class AcceptSupportTicketCommandHandler(IAssignmentRepository _assignmentRepository,
                                                  ISupportTicketRepository _supportTicketRepository,
                                                  IValidator<AcceptSupportTicketCommand> _validator
                                                 ) : IRequestHandler<AcceptSupportTicketCommand, Result>
        {
            public async Task<Result> Handle(AcceptSupportTicketCommand request, CancellationToken cancellationToken)
            {
                //Validate the Request
                var validationResult = _validator.Validate(request);
                if (!validationResult.IsValid)
                {
                    return Result.Failure(new Error("Validation.Error", "The request failed with validation error"));
                }

                //check if the Ticket Already Assigned
                var ticket = await _supportTicketRepository.GetTicketByIdAsync(request.ticketId);

                if (ticket.Status == SupportTicketStatus.Assigned)
                {
                    return Result.Failure(new Error("conflict", "Support Ticket alreay assigned"));
                }

                //create assignment
                var assignment = Assignment.Create(request.ticketId, request.agentId);
                await _assignmentRepository.AddAssignementAsync(assignment);

                //Change Card Status to Assigned
                ticket.ChangeStatus(SupportTicketStatus.Assigned);
                _supportTicketRepository.Update(ticket);

                return Result.Success(ticket);

            }
        }
    }
}
