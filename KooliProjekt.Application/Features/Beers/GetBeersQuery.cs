using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Beers
{
    public class GetBeersQuery : IRequest<List<Beer>> { }
}
