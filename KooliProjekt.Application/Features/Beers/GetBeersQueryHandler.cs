using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Beers
{
    public class GetBeersQueryHandler : IRequestHandler<GetBeersQuery, List<Beer>>
    {
        private readonly IBeerRepository _repo;

        public GetBeersQueryHandler(IBeerRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Beer>> Handle(GetBeersQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAllAsync();
        }
    }
}
