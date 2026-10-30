using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentNo { get; set; }
        // [Required]: must not be empty
        [Required]
        // [StringLength(100)]: at most 100 characters
        [StringLength(100)]
        public string? Name { get; set; }
                // [Required] + [EmailAddress]: must be given and must look like an email
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        
                // Phone must contain digits only (optional)
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Phone must contain numbers only.")]
        public string? Phone { get; set; }

            // [Range(16, 60)]: the number must be from 16 to 60
        [Range(16, 60)]
        public int? Age { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}