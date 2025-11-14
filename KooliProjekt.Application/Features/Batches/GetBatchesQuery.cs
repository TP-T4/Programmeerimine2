using MediatR;
using System.Collections.Generic;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Batches
{
    public class GetBatchesQuery : IRequest<List<Batch>>
    {
    }
}
