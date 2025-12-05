using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class GetIngredientsQuery : IRequest<PagedResult<Ingredient>>
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}

