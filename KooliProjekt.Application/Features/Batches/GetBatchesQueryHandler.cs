using MediatR;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Batches
{
    public class GetBatchesQueryHandler : IRequestHandler<GetBatchesQuery, List<Batch>>
    {
        private readonly ApplicationDbContext _context;

        public GetBatchesQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Batch>> Handle(GetBatchesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Batches.ToListAsync(cancellationToken);
        }
    }
}
