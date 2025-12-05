using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Beers
{
    public class GetBeersQuery : IRequest<PagedResult<Beer>>
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
