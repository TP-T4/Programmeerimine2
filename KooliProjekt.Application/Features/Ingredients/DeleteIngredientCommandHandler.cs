using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class DeleteIngredientCommandHandler : IRequestHandler<DeleteIngredientCommand, bool>
    {
        private readonly ApplicationDbContext _db;

        public DeleteIngredientCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Handle(DeleteIngredientCommand request, CancellationToken cancellationToken)
        {
            var entity = await _db.Ingredients.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity == null)
                return false;

            _db.Ingredients.Remove(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
