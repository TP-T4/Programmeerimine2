using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class DeleteTastingLogCommandHandler : IRequestHandler<DeleteTastingLogCommand, bool>
    {
        private readonly ITastingLogRepository _repo;

        public DeleteTastingLogCommandHandler(ITastingLogRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteTastingLogCommand request, CancellationToken cancellationToken)
        {
            return await _repo.DeleteAsync(request.Id);
        }
    }
}
