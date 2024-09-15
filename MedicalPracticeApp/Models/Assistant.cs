using MedicalPracticeApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalPracticeApp.Models
{
    public class Assistant
    {
        [Key]
        public int AssistantId { get; set; }  // Primary key

        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }

        // Foreign key to Doctor
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }  // Navigation property to Doctor
    }
}
