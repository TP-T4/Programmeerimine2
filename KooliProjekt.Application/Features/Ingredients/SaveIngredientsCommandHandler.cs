using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class SaveIngredientCommandHandler : IRequestHandler<SaveIngredientCommand, Ingredient>
    {
        private readonly ApplicationDbContext _db;

        public SaveIngredientCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Ingredient> Handle(SaveIngredientCommand request, CancellationToken cancellationToken)
        {
            var model = request.Ingredient;

            if (model.Id == 0)
                _db.Ingredients.Add(model);
            else
                _db.Ingredients.Update(model);

            await _db.SaveChangesAsync(cancellationToken);

            return model;
        }
    }
}
