using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostsCenter.Domain.Entities
{
    [Table("user")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }
        [Required]
        public virtual ICollection<Post> Posts { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}