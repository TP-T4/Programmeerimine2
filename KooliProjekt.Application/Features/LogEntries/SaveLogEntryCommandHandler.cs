using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.LogEntries
{
    public class SaveLogEntryCommandHandler : IRequestHandler<SaveLogEntryCommand, LogEntry>
    {
        private readonly ApplicationDbContext _db;

        public SaveLogEntryCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<LogEntry> Handle(SaveLogEntryCommand request, CancellationToken cancellationToken)
        {
            var model = request.LogEntry;

            if (model.Id == 0)
                _db.LogEntries.Add(model);
            else
                _db.LogEntries.Update(model);

            await _db.SaveChangesAsync(cancellationToken);

            return model;
        }
    }
}
