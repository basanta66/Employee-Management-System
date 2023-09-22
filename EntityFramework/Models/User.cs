using Microsoft.AspNetCore.Identity;
namespace EntityFramework.Models
{
    public class User : IdentityUser
    {
        public string Email { get; set; }
    }
}