using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class GetTastingLogQueryHandler : IRequestHandler<GetTastingLogQuery, TastingLog>
    {
        private readonly ApplicationDbContext _db;

        public GetTastingLogQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<TastingLog> Handle(GetTastingLogQuery request, CancellationToken cancellationToken)
        {
            return await _db.TastingLogs
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
