using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.LogEntries
{
    public class GetLogEntryQueryHandler : IRequestHandler<GetLogEntryQuery, LogEntry?>
    {
        private readonly ILogEntryRepository _repo;

        public GetLogEntryQueryHandler(ILogEntryRepository repo)
        {
            _repo = repo;
        }

        public async Task<LogEntry?> Handle(GetLogEntryQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByIdAsync(request.Id);
        }
    }
}
