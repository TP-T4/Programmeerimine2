using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.LogEntries
{
    public class GetLogEntriesQueryHandler : IRequestHandler<GetLogEntriesQuery, PagedResult<KooliProjekt.Application.Data.LogEntry>>
    {
        private readonly ApplicationDbContext _db;

        public GetLogEntriesQueryHandler(ApplicationDbContext db) => _db = db;

        public async Task<PagedResult<KooliProjekt.Application.Data.LogEntry>> Handle(GetLogEntriesQuery request, CancellationToken cancellationToken)
        {
            var query = _db.LogEntries
                .Include(l => l.Batch)
                .Include(l => l.User)
                .OrderByDescending(l => l.Date)
                .AsQueryable();

            return await query.GetPagedAsync(request.Page, request.PageSize);
        }
    }
}