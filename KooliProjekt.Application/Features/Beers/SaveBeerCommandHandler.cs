using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Beers
{
    public class SaveBeerCommandHandler : IRequestHandler<SaveBeerCommand, Beer>
    {
        private readonly IBeerRepository _repo;

        public SaveBeerCommandHandler(IBeerRepository repo)
        {
            _repo = repo;
        }

        public async Task<Beer> Handle(SaveBeerCommand request, CancellationToken cancellationToken)
        {
            return await _repo.SaveAsync(request.Beer);
        }
    }
}

