using AutoMapper;
using Blog.Entity.Dtos.Articles;
using Blog.Entity.Entities;

namespace Blog.Service.AutoMapper.Articles;

public class ArticleProfile:Profile
{
    public ArticleProfile()
    {
        CreateMap<ArticleDto,Article>().ReverseMap();
    }
}