using MediatR;
using PostsCenter.API.MediatR.Commands;
using PostsCenter.Domain.DTO;
using PostsCenter.Domain.Interfaces.Repositories;

namespace PostsCenter.API.MediatR.Handlers
{
    public class GetUserHandler : IRequestHandler<GetUserCommand, UserDTO>
    {
        private readonly IUserRepository _repository;

        public GetUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserDTO> Handle(GetUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return await _repository.GetById(request.Id);
            }
            catch (Exception ex)
            {
                throw new Exception($"could not be saved. Error {ex.Message}");
            }
        }
    }
}
