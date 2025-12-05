using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Users
{
    public class SaveUserCommandHandler : IRequestHandler<SaveUserCommand, User>
    {
        private readonly ApplicationDbContext _db;

        public SaveUserCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<User> Handle(SaveUserCommand request, CancellationToken cancellationToken)
        {
            var model = request.User;

            if (model.Id == 0)
                _db.Users.Add(model);
            else
                _db.Users.Update(model);

            await _db.SaveChangesAsync(cancellationToken);

            return model;
        }
    }
}
