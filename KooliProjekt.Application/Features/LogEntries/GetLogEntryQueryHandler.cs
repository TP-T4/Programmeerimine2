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
    public class GetLogEntryQueryHandler : IRequestHandler<GetLogEntryQuery, LogEntry>
    {
        private readonly ApplicationDbContext _db;

        public GetLogEntryQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<LogEntry> Handle(GetLogEntryQuery request, CancellationToken cancellationToken)
        {
            return await _db.LogEntries
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
