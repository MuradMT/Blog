using Microsoft.AspNetCore.Identity;

namespace Blog.Entity.Entities;

public class AppUser:IdentityUser<Guid>
{
    //Identity User comes from Microsoft Extensions Identity Stores package
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Guid ImageId { get; set; } = Guid.Parse("3224267D-94E7-4501-A7F3-0D376C3060A7");
    public Image Image { get; set; }

    public ICollection<Article> Artiicles { get; set; }
}