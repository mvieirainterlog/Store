using Microsoft.AspNetCore.Identity;

namespace Store.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
          
        public string Description { get; set; }

        public float  Price { get; set; }

    //  public OrderProduct OrderProduct { get; set; } 
        

       public ICollection<OrderProduct> OrderProducts { get; set; }

        //public Product()
        //{

        //}
    }
}
