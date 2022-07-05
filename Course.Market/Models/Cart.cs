using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.Market.Models
{
    public class Cart
    {
        public int Id { get; set; }
#nullable enable
        [Required]
        public ICollection<Product>? products { get; set; }
        [Required]
        public int? ShopperId { get; set; }
        [Required]
        public virtual Shopper? Shopper { get; set; }

    }
}
