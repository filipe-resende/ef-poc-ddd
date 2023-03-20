using AutoMapper;
using PostsCenter.Domain.DTO;
using PostsCenter.Domain.Entities;

namespace PostsCenter.API.AutoMapper
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<Post, PostDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
