using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweriesQueryHandler
        : IRequestHandler<GetBreweriesQuery, PagedResult<Brewery>>
    {
        private readonly ApplicationDbContext _db;

        public GetBreweriesQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<PagedResult<Brewery>> Handle(GetBreweriesQuery request, CancellationToken cancellationToken)
        {
            var query = _db.Breweries
                .Include(x => x.Beers)
                .OrderBy(x => x.Name)
                .AsQueryable();

            return await query.GetPagedAsync(request.Page, request.PageSize);
        }
    }
}
