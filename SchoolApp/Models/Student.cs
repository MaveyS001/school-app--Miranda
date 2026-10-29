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
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? Age { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}