using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Beers
{
    public class GetBeersQueryHandler
        : IRequestHandler<GetBeersQuery, PagedResult<Beer>>
    {
        private readonly ApplicationDbContext _db;

        public GetBeersQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<PagedResult<Beer>> Handle(GetBeersQuery request, CancellationToken cancellationToken)
        {
            var query = _db.Beers
                .Include(x => x.Brewery)
                .Include(x => x.Batches)
                .OrderBy(x => x.Name)
                .AsQueryable();

            return await query.GetPagedAsync(request.Page, request.PageSize);
        }
    }
}
