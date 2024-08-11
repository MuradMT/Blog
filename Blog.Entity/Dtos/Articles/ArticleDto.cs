namespace Blog.Entity.Dtos.Articles;

public class ArticleDto
{
    public  Guid Id { get; set; }
    public DateTime CreeatedDate { get; set; }
    public  string CreatedBy { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int ViewCount { get; set; }
}