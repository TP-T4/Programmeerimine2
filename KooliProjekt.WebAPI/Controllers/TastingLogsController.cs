using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.TastingLogs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TastingLogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TastingLogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PagedResult<TastingLog>>> Get([FromQuery] GetTastingLogsQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TastingLog>> GetById(int id)
        {
            var result = await _mediator.Send(new GetTastingLogQuery { Id = id });
            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<TastingLog>> Save([FromBody] TastingLog model)
        {
            return Ok(await _mediator.Send(new SaveTastingLogCommand { TastingLog = model }));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteTastingLogCommand { Id = id });
            return result ? Ok() : NotFound();
        }

    }
}
