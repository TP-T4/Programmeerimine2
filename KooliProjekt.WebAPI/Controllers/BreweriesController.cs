using Microsoft.AspNetCore.Mvc;
using MediatR;
using KooliProjekt.Application.Features.Breweries;
using KooliProjekt.Application.Data;

namespace KooliProjekt.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreweriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BreweriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Brewery>>> Get()
        {
            var result = await _mediator.Send(new GetBreweriesQuery());
            return Ok(result);
        }
    }
}
