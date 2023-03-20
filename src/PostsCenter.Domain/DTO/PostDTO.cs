using PostsCenter.Domain.Interfaces;

namespace PostsCenter.Domain.DTO
{
    public class PostDTO : IEntityDTO
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
