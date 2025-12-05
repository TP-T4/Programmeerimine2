using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace KooliProjekt.Application.Features.Batches
{
    public class DeleteBatchCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
