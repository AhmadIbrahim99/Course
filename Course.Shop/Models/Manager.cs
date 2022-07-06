using System.ComponentModel.DataAnnotations;

namespace Course.Shop.Models
{
    public class Manager
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
    }
}
