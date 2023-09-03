using Blog_Api.Business.ExtensionServices.Implements;
using Blog_Api.Business.ExtensionServices.Interfaces;
using Blog_Api.Business.ExternalServices.Implements;
using Blog_Api.Business.ExternalServices.Interfaces;
using Blog_Api.Business.Services.Implements;
using Blog_Api.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Blog_Api.Business;

public static class ServiceRegistration
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IFileService, FileService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IBlogService, BlogService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<ICommentService,CommentService>();
        services.AddHttpContextAccessor();

    }
}
