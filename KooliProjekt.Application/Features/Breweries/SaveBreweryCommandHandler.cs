using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Breweries
{
    public class SaveBreweryCommandHandler
        : IRequestHandler<SaveBreweryCommand, Brewery>
    {
        private readonly IBreweryRepository _repo;

        public SaveBreweryCommandHandler(IBreweryRepository repo)
        {
            _repo = repo;
        }

        public async Task<Brewery> Handle(SaveBreweryCommand request, CancellationToken cancellationToken)
        {
            return await _repo.SaveAsync(request.Brewery);
        }
    }
}

