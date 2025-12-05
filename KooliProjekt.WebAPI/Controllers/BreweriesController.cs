using Microsoft.AspNetCore.Mvc;
using MediatR;
using KooliProjekt.Application.Features.Breweries;
using KooliProjekt.Application.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

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
        [HttpGet("{id}")]
        public async Task<ActionResult<Brewery>> GetById(int id)
        {
            var result = await _mediator.Send(new GetBreweryQuery { Id = id });

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Brewery>> Save([FromBody] Brewery model)
        {
            var result = await _mediator.Send(new SaveBreweryCommand { Brewery = model });
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteBreweryCommand { Id = id });
            return result ? Ok() : NotFound();
        }


    }
}

