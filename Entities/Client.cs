using System.ComponentModel.DataAnnotations;

namespace SupremoSchedulingSystem.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Phone]
        public string? Phone { get; set; }

        // Navigation properties
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
