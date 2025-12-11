using MediatR;
using KooliProjekt.Application.Data;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.Users
{
    public class GetUsersQuery : IRequest<List<User>>
    {
    }
}
