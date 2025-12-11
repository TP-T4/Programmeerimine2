using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class GetIngredientsQueryHandler : IRequestHandler<GetIngredientsQuery, List<Ingredient>>
    {
        private readonly IIngredientRepository _repo;

        public GetIngredientsQueryHandler(IIngredientRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Ingredient>> Handle(GetIngredientsQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAllAsync();
        }
    }
}
