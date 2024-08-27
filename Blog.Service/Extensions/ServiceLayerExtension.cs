using Blog.Service.FluentValidators;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concretes;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;

namespace Blog.Service.Extensions;

public static class ServiceLayerExtension
{
    public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
    {
        services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();


        services.AddScoped<IArticleService,ArticleService>();
        services.AddScoped<ICategoryService,CategoryService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddControllersWithViews().AddFluentValidation(opt =>
        {
            opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
            opt.DisableDataAnnotationsValidation = true;
            //opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
        });

        return services;
    }
}