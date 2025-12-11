using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.LogEntries
{
    public class DeleteLogEntryCommandHandler : IRequestHandler<DeleteLogEntryCommand, bool>
    {
        private readonly ILogEntryRepository _repo;

        public DeleteLogEntryCommandHandler(ILogEntryRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteLogEntryCommand request, CancellationToken cancellationToken)
        {
            return await _repo.DeleteAsync(request.Id);
        }
    }
}
