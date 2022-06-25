using System;

namespace Course.FirstProject.Models
{
    public class Base
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy{ get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public Base() { CreatedAt = DateTime.Now; }
    }
}
