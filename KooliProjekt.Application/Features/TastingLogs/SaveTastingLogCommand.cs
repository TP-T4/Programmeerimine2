using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class SaveTastingLogCommand : IRequest<TastingLog>
    {
        public TastingLog TastingLog { get; set; }
    }
}
