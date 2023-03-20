using PostsCenter.API.DBContext;

namespace PostsCenter.API.Cross.DependencyInjections
{
    public static class DependencyInjections
    {
        public static void RegisterDependencies(IServiceCollection sevice)
        {
            sevice.AddScoped<Context>();
        }
    }
}
