using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class GetIngredientQuery : IRequest<Ingredient>
    {
        public int Id { get; set; }
    }
}
