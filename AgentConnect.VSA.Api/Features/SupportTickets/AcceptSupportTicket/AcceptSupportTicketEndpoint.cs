using Application.Commands;
using Microsoft.AspNetCore.Mvc;

namespace AgentConnect.VSA.Api.Features.SupportTickets
{
    public sealed partial class SupportTicketsController
    {
        [HttpPost("accept/{ticketId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Accept(Guid ticketId)
        {
            var command = await _mediator.Send(new AcceptSupportTicketCommand(ticketId));
            return Ok();
        }
    }
}
