using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Configurations;

public class RoleConfiguration:IEntityTypeConfiguration<AppRole>
{
    public void Configure(EntityTypeBuilder<AppRole> builder)
    {
        // Primary key
        builder.HasKey(r => r.Id);

        // Index for "normalized" role name to allow efficient lookups
        builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

        // Maps to the AspNetRoles table
        builder.ToTable("AspNetRoles");

        // A concurrency token for use with the optimistic concurrency checking
        builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

        // Limit the size of columns to use efficient database types
        builder.Property(u => u.Name).HasMaxLength(256);
        builder.Property(u => u.NormalizedName).HasMaxLength(256);

        // The relationships between Role and other entity types
        // Note that these relationships are configured with no navigation properties

        // Each Role can have many entries in the UserRole join table
        builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

        // Each Role can have many associated RoleClaims
        builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

        builder.HasData(new AppRole()
        {
            Id = Guid.Parse("F2917C68-B590-4DDC-BDF3-510936428C1E"),
            Name = "Super Admin",
            NormalizedName = "SUPER ADMIN",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        },
        new AppRole()
        {
            Id = Guid.Parse("2150ECC7-EA01-4D39-BCE2-3F4E68CB2692"),
            Name = "Admin",
            NormalizedName = "ADMIN",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        },
        new AppRole()
        {
            Id = Guid.Parse("9DC8B41E-7DE2-48BE-9915-F71D0A8BC06E"),
            Name = "User",
            NormalizedName = "User",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        });
    }
}