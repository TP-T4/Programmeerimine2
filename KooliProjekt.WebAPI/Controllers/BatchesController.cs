using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Batches;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BatchesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BatchesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PagedResult<Batch>>> Get([FromQuery] GetBatchesQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Batch>> GetById(int id)
        {
            var result = await _mediator.Send(new GetBatchQuery { Id = id });
            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Batch>> Save([FromBody] Batch model)
        {
            return Ok(await _mediator.Send(new SaveBatchCommand { Batch = model }));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteBatchCommand { Id = id });
            return result ? Ok() : NotFound();
        }

    }
}
