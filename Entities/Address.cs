using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupremoSchedulingSystem.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Street { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string State { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string ZipCode { get; set; } = null!;

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        // Navigation property
        public Client? Client { get; set; }
    }
}
