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
    public class DeleteBatchCommandHandler : IRequestHandler<DeleteBatchCommand, bool>
    {
        private readonly ApplicationDbContext _db;

        public DeleteBatchCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Handle(DeleteBatchCommand request, CancellationToken cancellationToken)
        {
            var entity = await _db.Batches.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity == null)
                return false;

            _db.Batches.Remove(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
