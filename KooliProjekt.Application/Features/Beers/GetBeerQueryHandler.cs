using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Beers
{
    public class GetBeerQueryHandler : IRequestHandler<GetBeerQuery, Beer?>
    {
        private readonly IBeerRepository _repo;

        public GetBeerQueryHandler(IBeerRepository repo)
        {
            _repo = repo;
        }

        public async Task<Beer?> Handle(GetBeerQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByIdAsync(request.Id);
        }
    }
}
