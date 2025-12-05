using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Batches
{
    public class GetBatchQueryHandler : IRequestHandler<GetBatchQuery, Batch>
    {
        private readonly ApplicationDbContext _db;

        public GetBatchQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Batch> Handle(GetBatchQuery request, CancellationToken cancellationToken)
        {
            return await _db.Batches
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
