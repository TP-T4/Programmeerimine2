using MediatR;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Beers
{
    public class GetBeersQueryHandler : IRequestHandler<GetBeersQuery, List<Beer>>
    {
        private readonly ApplicationDbContext _context;

        public GetBeersQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Beer>> Handle(GetBeersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Beers
                .Include(b => b.Brewery)
                .Include(b => b.Batches)
                .ToListAsync(cancellationToken);
        }
    }
}
