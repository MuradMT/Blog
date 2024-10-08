using Blog.Entity.Dtos.Categories;
using Blog.Entity.Entities;

namespace Blog.Entity.Dtos.Articles;

public class ArticleDto
{
    public  Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public  string CreatedBy { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Image Image { get; set; }
    public CategoryDto Category { get; set; }
    public bool IsDeleted { get; set; }
}