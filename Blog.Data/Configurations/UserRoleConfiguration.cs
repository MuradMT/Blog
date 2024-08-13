using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Configurations;

public class UserRoleConfiguration:IEntityTypeConfiguration<AppUserRole>
{
    public void Configure(EntityTypeBuilder<AppUserRole> builder)
    {
        // Primary key
        builder.HasKey(r => new { r.UserId, r.RoleId });

        // Maps to the AspNetUserRoles table
        builder.ToTable("AspNetUserRoles");

        builder.HasData(
            new AppUserRole()
            {
                UserId = Guid.Parse("52D21BCA-C91C-41E6-BB26-F2E5C33E2A46"),
                RoleId = Guid.Parse("F2917C68-B590-4DDC-BDF3-510936428C1E")
            }, 
            new AppUserRole()
            {
                UserId = Guid.Parse("E9EDE6B0-9D0D-48B1-A4A0-05FD5130E067"),
                RoleId = Guid.Parse("2150ECC7-EA01-4D39-BCE2-3F4E68CB2692")
            },new AppUserRole()
            {
                UserId = Guid.Parse("BB668E51-6F7E-4D1F-9E9F-0B842761C120"),
                RoleId = Guid.Parse("9DC8B41E-7DE2-48BE-9915-F71D0A8BC06E")
            });
    }
}