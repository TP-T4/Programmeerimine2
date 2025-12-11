using KooliProjekt.Application.Data;
using MediatR;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweriesQuery : IRequest<List<Brewery>>
    {
    }
}
