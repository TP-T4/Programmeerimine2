using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Ingredients;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredientsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IngredientsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET list (paged)
        [HttpGet]
        public async Task<ActionResult<PagedResult<Ingredient>>> Get([FromQuery] GetIngredientsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetById(int id)
        {
            var result = await _mediator.Send(new GetIngredientQuery { Id = id });

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // SAVE (create/update)
        [HttpPost]
        public async Task<ActionResult<Ingredient>> Save([FromBody] Ingredient model)
        {
            var result = await _mediator.Send(new SaveIngredientCommand { Ingredient = model });
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteIngredientCommand { Id = id });
            return result ? Ok() : NotFound();
        }

    }
}
