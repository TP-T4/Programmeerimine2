using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Breweries
{
    public class SaveBreweryCommand : IRequest<Brewery>
    {
        public Brewery Brewery { get; set; }
    }
}
