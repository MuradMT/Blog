using System.Reflection;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Context;

public class AppDbContext:DbContext
{
    public AppDbContext()
    {
        
    }

    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        
    }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Image> Images { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}