using Blog_Api.DataAccess.Repositories.Abstract;
using Blog_Api.DataAccess.Repositories.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Blog_Api.DataAccess;

public static class ServiceRegistration
{
    public static void AddRepoServices(this IServiceCollection services)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IBlogRepository, BlogRepository>();
        services.AddScoped<ICommentRepository, CommentRepository>();
        services.AddScoped<IBlogLikeRepository, BlogLikeRepository>();
    }
}
