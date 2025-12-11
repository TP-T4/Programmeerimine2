using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class SaveIngredientCommandHandler : IRequestHandler<SaveIngredientCommand, Ingredient>
    {
        private readonly IIngredientRepository _repo;

        public SaveIngredientCommandHandler(IIngredientRepository repo)
        {
            _repo = repo;
        }

        public async Task<Ingredient> Handle(SaveIngredientCommand request, CancellationToken cancellationToken)
        {
            return await _repo.SaveAsync(request.Ingredient);
        }
    }
}
