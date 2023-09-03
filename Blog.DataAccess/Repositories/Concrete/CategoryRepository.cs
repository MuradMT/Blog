using Blog_Api.Core.Entities;
using Blog_Api.DataAccess.Contexts;
using Blog_Api.DataAccess.Repositories.Abstract;

namespace Blog_Api.DataAccess.Repositories.Concrete;


public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(BlogContext context) : base(context)
    {
    }
}