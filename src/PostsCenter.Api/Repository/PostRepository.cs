using AutoMapper;
using PostsCenter.API.DBContext;
using PostsCenter.Domain.DTO;
using PostsCenter.Domain.Entities;
using PostsCenter.Domain.Interfaces.Repositories;

namespace PostsCenter.API.Repository
{
    public class PostRepository : Repository<Post, PostDTO>, IPostRepository
    {
        public PostRepository(Context dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
