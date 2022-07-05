using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.Market.Models
{
    public class Shopper
    {
        public int Id { get; set; }
#nullable enable
        [Required]
        public string? Name { get; set; }
#nullable enable
        [Required]
        public string? Email { get; set; }
#nullable enable
        [Required]
        public string? Password { get; set; }
#nullable enable
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public DateTime? DOB{ get; set; }
        
    }
}
