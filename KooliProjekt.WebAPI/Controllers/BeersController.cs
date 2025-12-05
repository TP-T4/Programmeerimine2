using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Beers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BeersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BeersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PagedResult<Beer>>> Get([FromQuery] GetBeersQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Beer>> GetById(int id)
        {
            var result = await _mediator.Send(new GetBeerQuery { Id = id });
            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Beer>> Save([FromBody] Beer model)
        {
            return Ok(await _mediator.Send(new SaveBeerCommand { Beer = model }));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteBeerCommand { Id = id });
            return result ? Ok() : NotFound();
        }

    }
}
