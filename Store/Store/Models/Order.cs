using Microsoft.AspNetCore.Identity;

namespace Store.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public float? Total { get; set; }

        // public OrderProduct OrderProduct { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }

        //  public IdentityUser? User { get; set; }

        public Order()
        {
            Total = 0;
        }


    }
}
