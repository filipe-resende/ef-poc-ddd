using MediatR;
using PostsCenter.Domain.DTO;

namespace PostsCenter.API.MediatR.Commands
{
    public class GetPostCommand : IRequest<PostDTO>
    {
        public GetPostCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}