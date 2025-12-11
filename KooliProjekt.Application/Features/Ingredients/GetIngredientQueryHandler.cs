using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class GetIngredientQueryHandler : IRequestHandler<GetIngredientQuery, Ingredient?>
    {
        private readonly IIngredientRepository _repo;

        public GetIngredientQueryHandler(IIngredientRepository repo)
        {
            _repo = repo;
        }

        public async Task<Ingredient?> Handle(GetIngredientQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByIdAsync(request.Id);
        }
    }
}
