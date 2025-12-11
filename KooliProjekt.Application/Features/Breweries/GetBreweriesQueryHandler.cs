using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweriesQueryHandler
        : IRequestHandler<GetBreweriesQuery, List<Brewery>>
    {
        private readonly IBreweryRepository _repo;

        public GetBreweriesQueryHandler(IBreweryRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Brewery>> Handle(GetBreweriesQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAllAsync();
        }
    }
}
