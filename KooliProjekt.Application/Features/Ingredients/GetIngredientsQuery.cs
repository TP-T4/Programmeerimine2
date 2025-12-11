using MediatR;
using KooliProjekt.Application.Data;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class GetIngredientsQuery : IRequest<List<Ingredient>>
    {
    }
}
