using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Model;
using MyApp.Application.Services;
using MyApp.Domain.Exceptions;

namespace MyApp.WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : Controller
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginModel model)
    {
        if (!await _authService.LoginAsync(model))
        {
            return Unauthorized(new { message = "Sai tài khoản hoặc mật khẩu" });
        }

        return Ok(new { message = "Đăng nhập thành công" });
    }

    [Route("partner/Register")]
    [HttpPost]
    public async Task<ActionResult> PartnerRegister(PartnerRegisterModel model)
    {
        if (!ModelState.IsValid) return View(model);
        try
        {
            await _authService.PartnerRegisterAsync(model);
        }
        catch (UserNameExistException)
        {
            return BadRequest(new { field = "UserName", message = "Tài khoản đã tồn tại" });
        }
        catch (EmailExistException)
        {
            return BadRequest(new { field = "Email", message = "Email đã tồn tại" });
        }

        return Ok(new { message = "Đăng ký thành công" });
    }

    [Route("endUser/Register")]
    [HttpPost]
    public async Task<ActionResult> EndUserRegister(EndUserRegisterModel model)
    {
        if (!ModelState.IsValid) return View(model);
        try
        {
            await _authService.endUserRegisterAsync(model);
        }
        catch (UserNameExistException)
        {
            return BadRequest(new { field = "UserName", message = "Tài khoản đã tồn tại" });
        }
        catch (EmailExistException)
        {
            return BadRequest(new { field = "Email", message = "Email đã tồn tại" });
        }

        return Ok(new { message = "Đăng ký thành công" });
    }

    [Authorize]
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        await _authService.LogoutAsync();
        return Ok(new { message = "Đăng xuất thành công" });
    }
}
