using AgentConnect.Api.Contract.SupportTickets;
using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgentConnect.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportTicketsController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost("create")]
        public async Task<IActionResult> CreateSupportTicket([FromBody] CreateSupportTicketRequest request)
        {
           var result = await _mediator.Send(new CreateSupportTicketCommand(request.Subject, request.Description, request.RequestedUserId));

            return result.IsSuccess ? Ok() : BadRequest();
        }

        [HttpPost("accept/{ticketId}/{agentId}")]
        public async Task<IActionResult> AcceptSupportTicket([FromRoute] Guid ticketId, [FromRoute] Guid agentId)
        {
            var result = await _mediator.Send(new AcceptSupportTicketCommand(ticketId, agentId));

            return result.IsSuccess ? Ok() : BadRequest();
        }

        [HttpPost("cancel/{ticketId}")]
        public async Task<IActionResult> CancelSupportTicket([FromBody] CancelSupportTicketRequest request)
        {
            var result = await _mediator.Send(new CancelSupportTicketCommand(request.UserId, request.TicketId, request.Reason));

            return result.IsSuccess ? Ok() : BadRequest();
        }

        [HttpPost("reject/{ticketId}")]
        public async Task<IActionResult> RejectSupportTicket([FromBody] CancelSupportTicketRequest request)
        {
            var result = await _mediator.Send(new CancelSupportTicketCommand(request.UserId, request.TicketId, request.Reason));

            return result.IsSuccess ? Ok() : BadRequest();
        }

    }
}
