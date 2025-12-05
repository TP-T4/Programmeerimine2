using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Beers
{
    public class GetBeerQueryHandler : IRequestHandler<GetBeerQuery, Beer>
    {
        private readonly ApplicationDbContext _db;

        public GetBeerQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Beer> Handle(GetBeerQuery request, CancellationToken cancellationToken)
        {
            return await _db.Beers
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
