using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Batches
{
    public class GetBatchesQueryHandler : IRequestHandler<GetBatchesQuery, List<Batch>>
    {
        private readonly IBatchRepository _repo;

        public GetBatchesQueryHandler(IBatchRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Batch>> Handle(GetBatchesQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAllAsync();
        }
    }
}
