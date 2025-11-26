using AgentConnect.VSA.Api.Contract.SupportTickets;
using Application.Commands;
using Microsoft.AspNetCore.Mvc;

namespace AgentConnect.VSA.Api.Features.SupportTickets
{
    public sealed partial class SupportTicketsController
    {
        [HttpPost("cancel")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Cancel([FromBody] CancelSupportTicketRequest request)
        {
            var command = await _mediator.Send(new CancelSupportTicketCommand(request.UserId, request.TicketId, request.Reason));
            return Ok();
        }
    }
}
