using Microsoft.AspNetCore.Mvc;

namespace AgentConnect.VSA.Api.Features.SupportTickets
{
    public sealed partial class SupportTicketsController
    {
        [HttpPost("accept/{ticketId}/{agentId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Accept([FromRoute] Guid ticketId, [FromRoute] Guid agentId)
        {
            var command = await _mediator.Send(new AcceptSupportTicketCommand(ticketId, agentId));
            return Ok();
        }
    }
}
