using System.Reflection;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Service.Extensions;

public static class ServiceLayerExtension
{
    public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
    {
        services.AddScoped<IArticleService,ArticleService>();
        services.AddScoped<ICategoryService,CategoryService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}