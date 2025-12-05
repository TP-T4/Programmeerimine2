using KooliProjekt.Application.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Breweries
{
    public class SaveBreweryCommandHandler : IRequestHandler<SaveBreweryCommand, Brewery>
    {
        private readonly ApplicationDbContext _db;

        public SaveBreweryCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Brewery> Handle(SaveBreweryCommand request, CancellationToken cancellationToken)
        {
            var model = request.Brewery;

            if (model.Id == 0)
                _db.Breweries.Add(model);
            else
                _db.Breweries.Update(model);

            await _db.SaveChangesAsync(cancellationToken);

            return model;
        }
    }
}
