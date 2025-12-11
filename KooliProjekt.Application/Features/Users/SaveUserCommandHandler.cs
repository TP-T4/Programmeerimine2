using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Users
{
    public class SaveUserCommandHandler : IRequestHandler<SaveUserCommand, User>
    {
        private readonly IUserRepository _repo;

        public SaveUserCommandHandler(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<User> Handle(SaveUserCommand request, CancellationToken cancellationToken)
        {
            return await _repo.SaveAsync(request.User);
        }
    }
}

