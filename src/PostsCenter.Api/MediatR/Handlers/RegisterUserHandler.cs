using MediatR;
using PostsCenter.API.MediatR.Commands;
using PostsCenter.Domain.DTO;
using PostsCenter.Domain.Interfaces.Repositories;

namespace PostsCenter.API.MediatR.Handlers
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Guid>
    {
        private readonly IUserRepository _repository;

        public RegisterUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = new UserDTO { Name = request.Nome };
                var result = await _repository.Add(user);
                return result.Id;
            }
            catch (Exception ex)
            {
                throw new Exception($"could not be saved. Error {ex.Message}");
            }
        }
    }
}
