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
    public class DeleteTastingLogCommandHandler : IRequestHandler<DeleteTastingLogCommand, bool>
    {
        private readonly ApplicationDbContext _db;

        public DeleteTastingLogCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Handle(DeleteTastingLogCommand request, CancellationToken cancellationToken)
        {
            var entity = await _db.TastingLogs.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity == null)
                return false;

            _db.TastingLogs.Remove(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
