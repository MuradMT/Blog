using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Data.Extensions;

public static class DataLayerExtension
{
    public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        return services;
    }
}