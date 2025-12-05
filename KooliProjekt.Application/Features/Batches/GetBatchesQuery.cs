using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Batches
{
    public class GetBatchesQuery : IRequest<PagedResult<Batch>>
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
