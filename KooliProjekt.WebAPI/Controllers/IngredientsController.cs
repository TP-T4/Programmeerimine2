using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Ingredients;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

        [HttpGet]
        public async Task<ActionResult<List<Ingredient>>> Get()
        {
            return Ok(await _mediator.Send(new GetIngredientsQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetById(int id)
        {
            var result = await _mediator.Send(new GetIngredientQuery { Id = id });
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Ingredient>> Save([FromBody] Ingredient model)
        {
            return Ok(await _mediator.Send(new SaveIngredientCommand { Ingredient = model }));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var ok = await _mediator.Send(new DeleteIngredientCommand { Id = id });
            if (!ok) return NotFound();
            return Ok();
        }
    }
}
