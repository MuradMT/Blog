using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Data.Extensions;

public static class DataLayerExtension
{
    public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt=>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}