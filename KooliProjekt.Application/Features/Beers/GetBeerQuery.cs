using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Beers
{
    public class GetBeerQuery : IRequest<Beer?>
    {
        public int Id { get; set; }
    }
}
