using MediatR;

namespace PostsCenter.API.MediatR.Commands
{
    public class RegisterUserCommand : IRequest<Guid>
    {
        public string Nome { get; set; }
    }
}