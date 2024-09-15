using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MedicalPracticeApp.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }  // Primary key

        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string PhoneNumber { get; set; }

        // Navigation property for relationships
        public ICollection<Visit> Visits { get; set; }  // A patient can have multiple visits
    }
}
