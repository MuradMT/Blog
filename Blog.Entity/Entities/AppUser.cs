using Microsoft.AspNetCore.Identity;

namespace Blog.Entity.Entities;

public class AppUser:IdentityUser<Guid>
{
    //Identity User comes from Microsoft Extensions Identity Stores package
    public string FirstName { get; set; }
    public string LastName { get; set; }
}