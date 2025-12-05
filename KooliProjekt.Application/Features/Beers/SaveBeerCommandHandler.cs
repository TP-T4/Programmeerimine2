using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Beers
{
    public class SaveBeerCommandHandler : IRequestHandler<SaveBeerCommand, Beer>
    {
        private readonly ApplicationDbContext _db;

        public SaveBeerCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Beer> Handle(SaveBeerCommand request, CancellationToken cancellationToken)
        {
            var model = request.Beer;

            if (model.Id == 0)
                _db.Beers.Add(model);
            else
                _db.Beers.Update(model);

            await _db.SaveChangesAsync(cancellationToken);

            return model;
        }
    }
}
