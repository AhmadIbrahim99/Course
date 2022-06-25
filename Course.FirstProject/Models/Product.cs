namespace Course.FirstProject.Models
{
    public class Product : Base
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price{ get; set; }

        public string ToString() => $"ID : {this.Id}, \nName : {this.Name},\nPrice: {this.Price}, \nCreatedAt : {this.CreatedAt}, \nCreatedBy : {this.CreatedBy}";

    }
}
