using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweriesQuery : IRequest<List<Brewery>> { }
}
