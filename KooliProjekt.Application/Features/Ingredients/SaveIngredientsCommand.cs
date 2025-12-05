using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class SaveIngredientCommand : IRequest<Ingredient>
    {
        public Ingredient Ingredient { get; set; }
    }
}
