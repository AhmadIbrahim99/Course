using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Course.Market.Models
{
    public class Category
    {
        public int Id { get; set; }
#nullable enable
        [Required]
        public string? Name { get; set; }
        [Required]
        public ICollection<Product>? Products { get; set; }

    }
}
