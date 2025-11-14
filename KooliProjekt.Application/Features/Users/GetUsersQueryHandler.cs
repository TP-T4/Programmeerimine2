using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Users
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, PagedResult<KooliProjekt.Application.Data.User>>
    {
        private readonly ApplicationDbContext _db;

        public GetUsersQueryHandler(ApplicationDbContext db) => _db = db;

        public async Task<PagedResult<KooliProjekt.Application.Data.User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var query = _db.Users
                .OrderBy(u => u.Username)
                .AsQueryable();

            return await query.GetPagedAsync(request.Page, request.PageSize);
        }
    }
}


