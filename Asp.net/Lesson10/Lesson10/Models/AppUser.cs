using Microsoft.AspNetCore.Identity;

namespace Lesson10.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public int Year { get; set; }
    }
}
