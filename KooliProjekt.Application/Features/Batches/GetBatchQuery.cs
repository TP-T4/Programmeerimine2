using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Batches
{
    public class GetBatchQuery : IRequest<Batch?>
    {
        public int Id { get; set; }
    }
}
