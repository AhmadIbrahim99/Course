using System;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
