using MediatR;
using System.ComponentModel.DataAnnotations;

namespace PostsCenter.API.MediatR.Commands
{
    public class RegisterPostCommand : IRequest<Guid>
    {
        [Required]
        public Guid UserId { get; set; }
        public string Title { get; set; }
    }
}