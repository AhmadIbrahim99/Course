using System.ComponentModel.DataAnnotations;

namespace Course.Shop.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? ManagerId { get; set; }
        public Manager Manager{ get; set; }
    }
}
