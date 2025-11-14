using MediatR;
using Microsoft.AspNetCore.Mvc;
using KooliProjekt.Application.Features.Batches;
using KooliProjekt.Application.Models;
using System.Collections.Generic;
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
        public async Task<ActionResult<List<Batch>>> Get()
        {
            var result = await _mediator.Send(new GetBatchesQuery());
            return Ok(result);
        }
    }
}
