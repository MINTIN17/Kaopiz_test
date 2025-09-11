using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MyApp.Application.Commons.Identity;
using MyApp.Domain.Data;
using MyApp.Infrastucture.Data;
using MyApp.Infrastucture.Repositories;
using MyApp.WebApp.Commons.Identity;
using MyApp.Domain.Entities;
using MyApp.Application.Services;
using MyApp.Application.Services.Interfaces;

namespace MyApp.WebApp.Extentions;

public static class ServiceExtentions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.Scan(scan => scan.FromAssemblyOf<BaseService>()
            .AddClasses(c => c.AssignableTo<BaseService>())
            .AsSelf()
            .WithScopedLifetime());
        services.Scan(scan => scan.FromAssemblyOf<IBaseService>()
            .AddClasses(c => c.AssignableTo<IBaseService>())
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        return services;
    }

    public static IServiceCollection AddRepositorys(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
        return services;
    }

    public static IServiceCollection ConfigureIdentity(this IServiceCollection services)
    {
        services.AddIdentity<User, IdentityRole<int>>(options =>
        {
            options.Password.RequireDigit = false;
            options.Password.RequiredLength = 6;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.SignIn.RequireConfirmedAccount = false;
        }).AddEntityFrameworkStores<MyAppDbContext>().AddDefaultTokenProviders();

        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/login";
            options.AccessDeniedPath = "/";
            options.LogoutPath = "/logout";
            options.ReturnUrlParameter = string.Empty;
        });
        return services;
    }

    public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MyAppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        return services;
    }

    public static IServiceCollection AddCurrentUser(this IServiceCollection services)
    {
        services.AddScoped<ICurrentUser, CurrentUser>();
        services.AddHttpContextAccessor();
        return services;
    }

}
