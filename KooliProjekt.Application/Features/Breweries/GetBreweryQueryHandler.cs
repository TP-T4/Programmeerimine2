using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweryQueryHandler
        : IRequestHandler<GetBreweryQuery, Brewery?>
    {
        private readonly IBreweryRepository _repo;

        public GetBreweryQueryHandler(IBreweryRepository repo)
        {
            _repo = repo;
        }

        public async Task<Brewery?> Handle(GetBreweryQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByIdAsync(request.Id);
        }
    }
}

