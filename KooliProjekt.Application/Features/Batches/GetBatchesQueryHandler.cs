using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Batches
{
    public class GetBatchesQueryHandler
        : IRequestHandler<GetBatchesQuery, PagedResult<Batch>>
    {
        private readonly ApplicationDbContext _db;

        public GetBatchesQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<PagedResult<Batch>> Handle(GetBatchesQuery request, CancellationToken cancellationToken)
        {
            var query = _db.Batches
                .Include(x => x.Beer)
                .Include(x => x.Ingredients)
                .Include(x => x.LogEntries)
                .Include(x => x.TastingLogs)
                .OrderByDescending(x => x.BrewDate)
                .AsQueryable();

            return await query.GetPagedAsync(request.Page, request.PageSize);
        }
    }
}
