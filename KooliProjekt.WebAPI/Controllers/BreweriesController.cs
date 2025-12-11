using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Breweries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            return Ok(await _mediator.Send(new GetBreweriesQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brewery>> GetById(int id)
        {
            var result = await _mediator.Send(new GetBreweryQuery { Id = id });
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Brewery>> Save([FromBody] Brewery model)
        {
            return Ok(await _mediator.Send(new SaveBreweryCommand { Brewery = model }));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var ok = await _mediator.Send(new DeleteBreweryCommand { Id = id });
            if (!ok) return NotFound();
            return Ok();
        }
    }
}
