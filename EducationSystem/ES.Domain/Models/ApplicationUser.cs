using Microsoft.AspNetCore.Identity;

namespace ES.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PersonalNumber { get; set; }
        public string? City { get; set; }
        public char? Gender { get; set; }

    }
}
