using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Users
{
    public class SaveUserCommand : IRequest<User>
    {
        public User User { get; set; }
    }
}
