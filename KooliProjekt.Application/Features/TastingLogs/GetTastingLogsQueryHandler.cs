using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class GetTastingLogsQueryHandler : IRequestHandler<GetTastingLogsQuery, List<TastingLog>>
    {
        private readonly ITastingLogRepository _repo;

        public GetTastingLogsQueryHandler(ITastingLogRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<TastingLog>> Handle(GetTastingLogsQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAllAsync();
        }
    }
}
