using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.LogEntries
{
    public class SaveLogEntryCommand : IRequest<LogEntry>
    {
        public LogEntry LogEntry { get; set; }
    }
}
