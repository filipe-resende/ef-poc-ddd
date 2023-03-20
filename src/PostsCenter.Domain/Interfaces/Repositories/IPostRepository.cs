﻿using PostsCenter.Domain.DTO;
using PostsCenter.Domain.Entities;

namespace PostsCenter.Domain.Interfaces.Repositories
{
    public interface IPostRepository : IRepository<Post, PostDTO>
    {
    }
}
