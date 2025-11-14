using Microsoft.AspNetCore.Mvc;
using MediatR;
using KooliProjekt.Application.Features.Beers;
using KooliProjekt.Application.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

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
        public async Task<ActionResult<List<Beer>>> Get()
        {
            var result = await _mediator.Send(new GetBeersQuery());
            return Ok(result);
        }
    }
}
