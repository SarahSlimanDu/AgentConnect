using AgentConnect.VSA.Api.Features.SupportTickets.CreateSupportTicket;
using Application.SupportTickets.Commands.CreateSupportTicket;
using Microsoft.AspNetCore.Mvc;

namespace AgentConnect.VSA.Api.Features.SupportTickets
{
    public sealed partial class SupportTicketsController
    {
        [HttpPost("create/{agentId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateSupportTicket([FromBody] CreateSupportTicketRequest request)
        {
            var result = await _mediator.Send(new CreateSupportTicketCommand(request.Subject, request.Description, request.RequestedUserId));

            return result.IsSuccess ? Ok() : BadRequest();
        }
    }
}
