using Microsoft.AspNetCore.Identity;


namespace MyApp.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public string FullName { get; set; } = string.Empty;

    }
}
