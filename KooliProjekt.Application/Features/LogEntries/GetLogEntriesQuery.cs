using System;
using MediatR;
using KooliProjekt.Application.Data;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.LogEntries
{
    public class GetLogEntriesQuery : IRequest<List<LogEntry>>
    {
    }
}
