using Blog_Api.Core.Entities;
using Blog_Api.DataAccess.Contexts;
using Blog_Api.DataAccess.Repositories.Abstract;

namespace Blog_Api.DataAccess.Repositories.Concrete;


public class BlogRepository : Repository<Blog>, IBlogRepository
{
    public BlogRepository(BlogContext context) : base(context)
    {
    }
}
