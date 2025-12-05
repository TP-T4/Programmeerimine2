using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class GetTastingLogQuery : IRequest<TastingLog>
    {
        public int Id { get; set; }
    }
}
