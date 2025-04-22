using System.ComponentModel.DataAnnotations;

namespace SupremoSchedulingSystem.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        public string FullName { get; set; } = null!;

        [Required]
        public string Role { get; set; } = null!;
    }
}
