using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweryQueryHandler : IRequestHandler<GetBreweryQuery, Brewery>
    {
        private readonly ApplicationDbContext _db;

        public GetBreweryQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Brewery> Handle(GetBreweryQuery request, CancellationToken cancellationToken)
        {
            return await _db.Breweries
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
