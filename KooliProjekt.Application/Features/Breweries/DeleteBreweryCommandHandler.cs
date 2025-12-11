using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Breweries
{
    public class DeleteBreweryCommandHandler
        : IRequestHandler<DeleteBreweryCommand, bool>
    {
        private readonly IBreweryRepository _repo;

        public DeleteBreweryCommandHandler(IBreweryRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteBreweryCommand request, CancellationToken cancellationToken)
        {
            return await _repo.DeleteAsync(request.Id);
        }
    }
}
