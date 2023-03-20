using MediatR;
using PostsCenter.Domain.DTO;

namespace PostsCenter.API.MediatR.Commands
{
    public class GetUserCommand : IRequest<UserDTO>
    {
        public GetUserCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}