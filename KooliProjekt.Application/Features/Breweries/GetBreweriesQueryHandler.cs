using MediatR;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweriesQueryHandler
        : IRequestHandler<GetBreweriesQuery, PagedResult<Brewery>>
    {
        private readonly IBreweryRepository _repo;

        public GetBreweriesQueryHandler(IBreweryRepository repo)
        {
            _repo = repo;
        }

        public async Task<PagedResult<Brewery>> Handle(GetBreweriesQuery request, CancellationToken cancellationToken)
        {
            // Eeldus: IBreweryRepository sisaldab meetodit GetPagedAsync
            return await _repo.GetPagedAsync(request.Page, request.PageSize);
        }
    }
}
