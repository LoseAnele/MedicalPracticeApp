using MedicalPracticeApp.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalPracticeApp.Models
{
    public class Visit
    {
        [Key]
        public int VisitId { get; set; }  // Primary key

        public DateTime VisitDate { get; set; }
        public required string Notes { get; set; }

        // Foreign key to Doctor
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }  // Navigation property to Doctor

        // Foreign key to Patient
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }  // Navigation property to Patient
    }
}
