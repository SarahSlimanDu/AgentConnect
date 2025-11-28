using Application.Commands;
using Domain.Core.Result;
using Domain.Entities;
using Domain.Enums;
using Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Application.CommandHandlers
{
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
            var ticket =  await _supportTicketRepository.GetTicketByIdAsync(request.ticketId);

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
