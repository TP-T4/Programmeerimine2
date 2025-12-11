using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.LogEntries
{
    public class SaveLogEntryCommandHandler : IRequestHandler<SaveLogEntryCommand, LogEntry>
    {
        private readonly ILogEntryRepository _repo;

        public SaveLogEntryCommandHandler(ILogEntryRepository repo)
        {
            _repo = repo;
        }

        public async Task<LogEntry> Handle(SaveLogEntryCommand request, CancellationToken cancellationToken)
        {
            return await _repo.SaveAsync(request.LogEntry);
        }
    }
}
