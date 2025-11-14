using MediatR;
using KooliProjekt.Application.Data;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.Beers
{
    public class GetBeersQuery : IRequest<List<Beer>> { }
}
