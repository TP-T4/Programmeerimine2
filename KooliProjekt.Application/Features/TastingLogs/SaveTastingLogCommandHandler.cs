using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class SaveTastingLogCommandHandler : IRequestHandler<SaveTastingLogCommand, TastingLog>
    {
        private readonly ApplicationDbContext _db;

        public SaveTastingLogCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<TastingLog> Handle(SaveTastingLogCommand request, CancellationToken cancellationToken)
        {
            var model = request.TastingLog;

            if (model.Id == 0)
                _db.TastingLogs.Add(model);
            else
                _db.TastingLogs.Update(model);

            await _db.SaveChangesAsync(cancellationToken);

            return model;
        }
    }
}
