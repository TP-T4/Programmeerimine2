using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Batches
{
    public class SaveBatchCommandHandler : IRequestHandler<SaveBatchCommand, Batch>
    {
        private readonly ApplicationDbContext _db;

        public SaveBatchCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Batch> Handle(SaveBatchCommand request, CancellationToken cancellationToken)
        {
            var model = request.Batch;

            if (model.Id == 0)
                _db.Batches.Add(model);
            else
                _db.Batches.Update(model);

            await _db.SaveChangesAsync(cancellationToken);

            return model;
        }
    }
}

