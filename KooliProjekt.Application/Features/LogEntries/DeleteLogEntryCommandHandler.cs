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
    public class DeleteLogEntryCommandHandler : IRequestHandler<DeleteLogEntryCommand, bool>
    {
        private readonly ApplicationDbContext _db;

        public DeleteLogEntryCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Handle(DeleteLogEntryCommand request, CancellationToken cancellationToken)
        {
            var entity = await _db.LogEntries.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity == null)
                return false;

            _db.LogEntries.Remove(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
