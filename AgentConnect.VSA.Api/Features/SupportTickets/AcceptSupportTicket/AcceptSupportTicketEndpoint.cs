using Application.Commands;
using Microsoft.AspNetCore.Mvc;

namespace AgentConnect.VSA.Api.Features.SupportTickets
{
    public sealed partial class SupportTicketsController
    {
        [HttpPost("accept")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Accept(Guid supportTicketId)
        {
            var command = await _mediator.Send(new AcceptSupportTicketCommand(supportTicketId));
            return Ok();
        }
    }
}
