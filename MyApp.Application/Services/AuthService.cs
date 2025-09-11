using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using MyApp.Application.Commons.Identity;
using MyApp.Application.Model;
using MyApp.Domain.Data;
using MyApp.Domain.Entities;
using MyApp.Domain.Exceptions;

namespace MyApp.Application.Services;

public class AuthService : BaseService
{

    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;
    private readonly IRepository<EndUser> _endUserRepo;
    private readonly IRepository<Partner> _partnerRepo;
    private readonly ILogger<AuthService> _logger;

    public AuthService(
        SignInManager<User> signInManager,
        UserManager<User> userManager,
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ICurrentUser currentUser,
        IRepository<EndUser> endUserRepo,
        IRepository<Partner> partnerRepo,
        ILogger<AuthService> logger
    ) : base(unitOfWork, mapper, currentUser)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _endUserRepo = endUserRepo;
        _partnerRepo = partnerRepo;
        _logger = logger;
    }
    public Task<User> GetUserAsync()
    {
        throw new NotImplementedException();
    }
    public async Task<bool> LoginAsync(LoginModel model)
    {
        var user = await _userManager.FindByEmailAsync(model.UserNameOrEmail)
                   ?? await _userManager.FindByNameAsync(model.UserNameOrEmail);
        if (user == null)
            return false;

        var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

        if (!result.Succeeded)
            return false;

        return true;
    }

    public async Task<bool> PartnerRegisterAsync(PartnerRegisterModel model)
    {
        if (await _userManager.FindByNameAsync(model.UserName) != null)
            throw new UserNameExistException("Username already exists");
        if (await _userManager.FindByEmailAsync(model.Email) != null)
            throw new EmailExistException("Email already exists");
        var user = new User
        {
            UserName = model.UserName,
            FullName = model.FullName,
            Email = model.Email
        };
        var result = await _userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
            user = await _userManager.FindByNameAsync(model.UserName);
            user.EmailConfirmed = true;
            _partnerRepo.Add(new Partner{ UserId = user.Id, About = model.About });
            await UnitOfWork.SaveChangesAsync();
            await _signInManager.SignInAsync(user, false);
            return true;
        }

        return false;
    }

    public async Task<bool> endUserRegisterAsync(EndUserRegisterModel model)
    {
        if (await _userManager.FindByNameAsync(model.UserName) != null)
            throw new UserNameExistException("Username already exists");
        if (await _userManager.FindByEmailAsync(model.Email) != null)
            throw new EmailExistException("Email already exists");
        var user = new User
        {
            UserName = model.UserName,
            FullName = model.FullName,
            Email = model.Email
        };
        var result = await _userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
            user = await _userManager.FindByNameAsync(model.UserName);
            user.EmailConfirmed = true;
            _endUserRepo.Add(new EndUser { UserId = user.Id, Address = model.Address });
            await UnitOfWork.SaveChangesAsync();
            await _signInManager.SignInAsync(user, false);
            return true;
        }

        return false;
    }
    public async Task LogoutAsync()
    {
        await _signInManager.SignOutAsync();
    }
}
