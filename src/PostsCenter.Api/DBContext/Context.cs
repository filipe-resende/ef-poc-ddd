using Microsoft.EntityFrameworkCore;
using PostsCenter.Domain.Entities;
using PostsCenter.Infraestructure.Data.Mapping;

namespace PostsCenter.API.DBContext;
public class Context : DbContext
{
    public Context(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMap());
        modelBuilder.ApplyConfiguration(new PostMap());
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
}

