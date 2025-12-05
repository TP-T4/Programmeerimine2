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
    public class DeleteBeerCommandHandler : IRequestHandler<DeleteBeerCommand, bool>
    {
        private readonly ApplicationDbContext _db;

        public DeleteBeerCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Handle(DeleteBeerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _db.Beers.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity == null)
                return false;

            _db.Beers.Remove(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
