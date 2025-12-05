using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Users
{
    public class GetUserQuery : IRequest<User>
    {
        public int Id { get; set; }
    }
}
