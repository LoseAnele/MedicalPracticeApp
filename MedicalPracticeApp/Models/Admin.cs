using System.ComponentModel.DataAnnotations;

namespace MedicalPracticeApp.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }  // Primary key

        public required string Username { get; set; }
        public required string Password { get; set; }  
    }
}
