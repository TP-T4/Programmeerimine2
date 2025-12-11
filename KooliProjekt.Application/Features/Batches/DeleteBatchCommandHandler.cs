using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Batches
{
    public class DeleteBatchCommandHandler : IRequestHandler<DeleteBatchCommand, bool>
    {
        private readonly IBatchRepository _repo;

        public DeleteBatchCommandHandler(IBatchRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteBatchCommand request, CancellationToken cancellationToken)
        {
            return await _repo.DeleteAsync(request.Id);
        }
    }
}
