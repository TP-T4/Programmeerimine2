using MediatR;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweriesQueryHandler : IRequestHandler<GetBreweriesQuery, List<Brewery>>
    {
        private readonly ApplicationDbContext _context;

        public GetBreweriesQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Brewery>> Handle(GetBreweriesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Breweries
                .Include(b => b.Beers)
                .ToListAsync(cancellationToken);
        }
    }
}
