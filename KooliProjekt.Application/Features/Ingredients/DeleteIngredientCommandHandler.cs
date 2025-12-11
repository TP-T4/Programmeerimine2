using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class DeleteIngredientCommandHandler : IRequestHandler<DeleteIngredientCommand, bool>
    {
        private readonly IIngredientRepository _repo;

        public DeleteIngredientCommandHandler(IIngredientRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteIngredientCommand request, CancellationToken cancellationToken)
        {
            return await _repo.DeleteAsync(request.Id);
        }
    }
}
