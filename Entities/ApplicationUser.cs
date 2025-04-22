using Microsoft.AspNetCore.Identity;

namespace SupremoSchedulingSystem.Entities
{
    public class ApplicationUser : IdentityUser
    {
        // Additional properties can be added here, e.g. FullName, etc.
        public string? FullName { get; set; }
    }
}
