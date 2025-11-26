using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgentConnect.VSA.Api.Features.SupportTickets
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed partial class SupportTicketsController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;
    }
}
