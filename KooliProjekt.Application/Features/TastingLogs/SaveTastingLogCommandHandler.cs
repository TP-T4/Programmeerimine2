using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class SaveTastingLogCommandHandler : IRequestHandler<SaveTastingLogCommand, TastingLog>
    {
        private readonly ITastingLogRepository _repo;

        public SaveTastingLogCommandHandler(ITastingLogRepository repo)
        {
            _repo = repo;
        }

        public async Task<TastingLog> Handle(SaveTastingLogCommand request, CancellationToken cancellationToken)
        {
            return await _repo.SaveAsync(request.TastingLog);
        }
    }
}

