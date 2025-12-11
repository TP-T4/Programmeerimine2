using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Beers
{
    public class DeleteBeerCommandHandler : IRequestHandler<DeleteBeerCommand, bool>
    {
        private readonly IBeerRepository _repo;

        public DeleteBeerCommandHandler(IBeerRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteBeerCommand request, CancellationToken cancellationToken)
        {
            return await _repo.DeleteAsync(request.Id);
        }
    }
}
