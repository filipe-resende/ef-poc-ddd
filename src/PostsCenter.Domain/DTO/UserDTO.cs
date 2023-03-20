using PostsCenter.Domain.Entities;
using PostsCenter.Domain.Interfaces;

namespace PostsCenter.Domain.DTO
{
    public class UserDTO : IEntityDTO
    {
        public string Name { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; } = Enumerable.Empty<Post>();
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
