using MediatR;
using Microsoft.AspNetCore.Mvc;
using KooliProjekt.Application.Features.Users;
using KooliProjekt.Application.Data;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PagedResult<User>>> Get([FromQuery] GetUsersQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(int id)
        {
            var result = await _mediator.Send(new GetUserQuery { Id = id });
            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<User>> Save([FromBody] User model)
        {
            return Ok(await _mediator.Send(new SaveUserCommand { User = model }));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteUserCommand { Id = id });
            return result ? Ok() : NotFound();
        }

    }
}
