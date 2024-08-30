using Blog.Entity.Dtos.Categories;
using Microsoft.AspNetCore.Http;

namespace Blog.Entity.Dtos.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public IFormFile Photo { get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
