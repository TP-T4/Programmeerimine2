using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class GetTastingLogQueryHandler : IRequestHandler<GetTastingLogQuery, TastingLog?>
    {
        private readonly ITastingLogRepository _repo;

        public GetTastingLogQueryHandler(ITastingLogRepository repo)
        {
            _repo = repo;
        }

        public async Task<TastingLog?> Handle(GetTastingLogQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByIdAsync(request.Id);
        }
    }
}
