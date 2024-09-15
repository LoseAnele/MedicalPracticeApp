using MedicalPracticeApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MedicalPracticeApp.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }  // Primary key
        public required string Name { get; set; }
        public required string Specialty { get; set; }
        public required string PhoneNumber { get; set; }

        // Navigation property for relationships
        public ICollection<Visit> Visits { get; set; }  // A doctor can have many visits

        // A doctor can have multiple assistants
        public ICollection<Assistant> Assistants { get; set; }
    }
}
