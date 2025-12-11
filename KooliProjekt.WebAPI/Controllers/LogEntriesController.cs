using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.LogEntries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogEntriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LogEntriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<LogEntry>>> Get()
        {
            return Ok(await _mediator.Send(new GetLogEntriesQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LogEntry>> GetById(int id)
        {
            var result = await _mediator.Send(new GetLogEntryQuery { Id = id });
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<LogEntry>> Save([FromBody] LogEntry model)
        {
            return Ok(await _mediator.Send(new SaveLogEntryCommand { LogEntry = model }));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var ok = await _mediator.Send(new DeleteLogEntryCommand { Id = id });
            if (!ok) return NotFound();
            return Ok();
        }
    }
}
