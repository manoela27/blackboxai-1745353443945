using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupremoSchedulingSystem.Entities
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime AppointmentDateTime { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }

        [StringLength(50)]
        public string? Status { get; set; }

        // Navigation properties
        public Client? Client { get; set; }
        public Employee? Employee { get; set; }
    }
}
