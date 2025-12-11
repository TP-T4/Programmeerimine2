using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.LogEntries
{
    public class GetLogEntriesQueryHandler : IRequestHandler<GetLogEntriesQuery, List<LogEntry>>
    {
        private readonly ILogEntryRepository _repo;

        public GetLogEntriesQueryHandler(ILogEntryRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<LogEntry>> Handle(GetLogEntriesQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAllAsync();
        }
    }
}
