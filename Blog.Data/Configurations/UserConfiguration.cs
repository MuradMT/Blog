using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Configurations;

public class UserConfiguration:IEntityTypeConfiguration<AppUser>
{
    //Got configuration settings from here
    //https://learn.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-8.0
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var superAdmin = new AppUser()
            {
                Id = Guid.Parse("52D21BCA-C91C-41E6-BB26-F2E5C33E2A46"),
                UserName = "superadmin@gmail.com",
                NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                PhoneNumber = "+994991234567",
                FirstName = "Murad",
                LastName = "Mammadzada",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("3224267D-94E7-4501-A7F3-0D376C3060A7")
            };
            superAdmin.PasswordHash = GenerateHashedPassword(superAdmin, "123456");
            
            var normalAdmin = new AppUser()
            {
                Id = Guid.Parse("E9EDE6B0-9D0D-48B1-A4A0-05FD5130E067"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "+994991234566",
                FirstName = "Admin",
                LastName = "AdminUser",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("3224267D-94E7-4501-A7F3-0D376C3060A7")
            };
            normalAdmin.PasswordHash = GenerateHashedPassword(normalAdmin, "1234567");
            
            var normalUser = new AppUser()
            {
                Id = Guid.Parse("BB668E51-6F7E-4D1F-9E9F-0B842761C120"),
                UserName = "user@gmail.com",
                NormalizedUserName = "USER@GMAIL.COM",
                Email = "user@gmail.com",
                NormalizedEmail = "USER@GMAIL.COM",
                PhoneNumber = "+994991234565",
                FirstName = "User",
                LastName = "NormalUser",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("3224267D-94E7-4501-A7F3-0D376C3060A7")
            };
            normalUser.PasswordHash = GenerateHashedPassword(normalUser, "12345678");

            builder.HasData(superAdmin,normalAdmin,normalUser);
    }

    private string GenerateHashedPassword(AppUser user, string password)
    {
        var passwordHasher = new PasswordHasher<AppUser>();
        return passwordHasher.HashPassword(user, password);
    }
}