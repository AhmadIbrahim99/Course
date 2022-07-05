using System.ComponentModel.DataAnnotations;

namespace Course.Market.Models
{
    public class Product
    {
        public int Id { get; set; }
#nullable enable
        [Required]
        public string? Name { get; set; }
        [Required]
        public double? SalePrice { get; set; }
        [Required]
        public double? Price { get; set; }
        [Required]
        public bool? IsOnSale{ get; set; }
        [Required]
        public int? Total { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        [Required]
        public virtual Category? Category { get; set; }
        [Required]
        public int? CartId { get; set; }
        [Required]
        public virtual Cart? Cart { get; set; }
    }
}
