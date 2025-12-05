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
    public class GetIngredientQueryHandler : IRequestHandler<GetIngredientQuery, Ingredient>
    {
        private readonly ApplicationDbContext _db;

        public GetIngredientQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Ingredient> Handle(GetIngredientQuery request, CancellationToken cancellationToken)
        {
            return await _db.Ingredients
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
