using MediatR;
using KooliProjekt.Application.Data;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweriesQuery : IRequest<List<Brewery>> { }
}
