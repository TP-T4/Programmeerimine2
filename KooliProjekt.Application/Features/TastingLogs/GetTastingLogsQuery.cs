using MediatR;
using KooliProjekt.Application.Data;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.TastingLogs
{
    public class GetTastingLogsQuery : IRequest<List<TastingLog>>
    {
    }
}
