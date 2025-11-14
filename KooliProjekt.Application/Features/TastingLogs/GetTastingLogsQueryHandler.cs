using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class GetTastingLogsQueryHandler : IRequestHandler<GetTastingLogsQuery, PagedResult<KooliProjekt.Application.Data.TastingLog>>
    {
        private readonly ApplicationDbContext _db;

        public GetTastingLogsQueryHandler(ApplicationDbContext db) => _db = db;

        public async Task<PagedResult<KooliProjekt.Application.Data.TastingLog>> Handle(GetTastingLogsQuery request, CancellationToken cancellationToken)
        {
            var query = _db.TastingLogs
                .Include(t => t.Batch)
                .Include(t => t.User)
                .OrderByDescending(t => t.Date)
                .AsQueryable();

            return await query.GetPagedAsync(request.Page, request.PageSize);
        }
    }
}
