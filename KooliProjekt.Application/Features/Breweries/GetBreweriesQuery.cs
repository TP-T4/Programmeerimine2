using MediatR;
using KooliProjekt.Application.Data;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.Breweries
{
    public class GetBreweriesQuery : IRequest<List<Brewery>> {

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;

    }
}
