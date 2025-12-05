using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Ingredients
{
    public class GetIngredientsQueryHandler : IRequestHandler<GetIngredientsQuery, PagedResult<Ingredient>>
    {
        private readonly ApplicationDbContext _db;

        public GetIngredientsQueryHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<PagedResult<Ingredient>> Handle(GetIngredientsQuery request, CancellationToken cancellationToken)
        {
            return await _db.Ingredients
                .OrderBy(x => x.Id)
                .GetPagedAsync(request.Page, request.PageSize);
        }
    }
}
