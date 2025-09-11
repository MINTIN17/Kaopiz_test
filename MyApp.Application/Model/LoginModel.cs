using System.ComponentModel.DataAnnotations;

namespace MyApp.Application.Model;

public class LoginModel
{
    [Required(ErrorMessage = "Email hoặc Username là bắt buộc")]
    public string UserNameOrEmail { get; set; }

    [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public bool RememberMe { get; set; }
}

