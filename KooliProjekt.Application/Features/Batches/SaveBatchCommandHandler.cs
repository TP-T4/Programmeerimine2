using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Batches
{
    public class SaveBatchCommandHandler : IRequestHandler<SaveBatchCommand, Batch>
    {
        private readonly IBatchRepository _repo;

        public SaveBatchCommandHandler(IBatchRepository repo)
        {
            _repo = repo;
        }

        public async Task<Batch> Handle(SaveBatchCommand request, CancellationToken cancellationToken)
        {
            return await _repo.SaveAsync(request.Batch);
        }
    }
}


