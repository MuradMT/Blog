using Blog.Entity.Dtos.Categories;

namespace Blog.Entity.Dtos.Articles;

public class ArticleDto
{
    public  Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public  string CreatedBy { get; set; }
    public string Title { get; set; }
    public CategoryDto Category { get; set; }
    public bool IsDeleted { get; set; }
}