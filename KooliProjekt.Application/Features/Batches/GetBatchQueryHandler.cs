using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Batches
{
    public class GetBatchQueryHandler : IRequestHandler<GetBatchQuery, Batch?>
    {
        private readonly IBatchRepository _repo;

        public GetBatchQueryHandler(IBatchRepository repo)
        {
            _repo = repo;
        }

        public async Task<Batch?> Handle(GetBatchQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByIdAsync(request.Id);
        }
    }
}
