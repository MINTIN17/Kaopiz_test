using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyApp.Domain.Constants;
using MyApp.Domain.Entities;

namespace MyApp.Infrastucture.Data;

public static class SeedData
{
    public static void AddIdentitySeedData(this ModelBuilder modelBuilder)
    {
        var roles = GetDefaultRoles();
        modelBuilder.Entity<IdentityRole<int>>().HasData(roles);

        var admin = GetAdmin();
        modelBuilder.Entity<User>().HasData(admin);
        modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
        {
            RoleId = roles.First(r => r.Name == AppRole.Admin).Id,
            UserId = admin.Id
        });

        var users = GetUsers();
        modelBuilder.Entity<User>().HasData(users);

        var partners = GetPartners(users.Take(5).ToList());
        modelBuilder.Entity<Partner>().HasData(partners);
        modelBuilder.Entity<IdentityUserRole<int>>().HasData(partners.Select(p => new IdentityUserRole<int>
        {
            RoleId = roles.First(r => r.Name == AppRole.Partner).Id,
            UserId = p.UserId
        }));

        var endUsers = GetEndUsers(users.Skip(5).Take(5).ToList());
        modelBuilder.Entity<EndUser>().HasData(endUsers);
    }

    private static User GetAdmin()
    {
        var admin = new User
        {
            Id = 1,
            FullName = "Admin",
            NormalizedUserName = "ADMIN",
            Email = "admin@myapp.com",
            NormalizedEmail = "ADMIN@MYAPP.COM",
            PhoneNumber = "123456789",
            UserName = "Admin",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString()
        };
        admin.PasswordHash = new PasswordHasher<User>().HashPassword(admin, "Admin123");
        return admin;
    }

    private static List<IdentityRole<int>> GetDefaultRoles()
    {
        return new List<IdentityRole<int>>
        {
            new() { Id = 1, Name = AppRole.Admin, NormalizedName = AppRole.Admin.ToUpper() },
            new() { Id = 2, Name = AppRole.Partner, NormalizedName = AppRole.Partner.ToUpper() }
        };
    }

    private static List<User> GetUsers()
    {
        var users = new Faker<User>("vi")
            .RuleFor(u => u.Id, f => f.IndexFaker + 2)
            .RuleFor(u => u.FullName, f => $"{f.Name.LastName()} {f.Name.FirstName()}")
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.UserName, (_, u) => u.Email)
            .RuleFor(u => u.NormalizedEmail, (_, u) => u.Email?.ToUpper())
            .RuleFor(u => u.NormalizedUserName, (_, u) => u.UserName?.ToUpper())
            .RuleFor(u => u.EmailConfirmed, _ => true)
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(u => u.SecurityStamp, _ => Guid.NewGuid().ToString())
            .RuleFor(u => u.PasswordHash, (f, u) => new PasswordHasher<User>().HashPassword(u, "User@123"))
            .Generate(10);
        return users;
    }

    private static List<Partner> GetPartners(List<User> users)
    {
        return users.Select((u, index) => new Partner
        {
            Id = index + 1,
            UserId = u.Id,
            About = "Thông tin partner"
        }).ToList();
    }

    private static List<EndUser> GetEndUsers(List<User> users)
    {
        return users.Select((u, index) => new EndUser
        {
            Id = index + 6,
            UserId = u.Id,
            Address = new Faker().Address.StreetAddress()
        }).ToList();
    }
}
