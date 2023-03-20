using PostsCenter.API.DBContext;
using PostsCenter.API.Repository;
using PostsCenter.Domain.Interfaces.Repositories;

namespace PostsCenter.API.Configurations
{
    public static class DependencyRepositoryCollections
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddScoped<Context>();
            service.AddScoped<IPostRepository, PostRepository>();
            service.AddScoped<IUserRepository, UserRepository>();

            return service;
        }
    }
}
