using Microsoft.AspNetCore.Identity;

namespace Store.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public enum Status { Waiting,
            Finished }
       

        public Order orderId { get; set; }
        public Status status { get; set; }
        //public IdentityUser? User { get; set; }

        public OrderStatus()
        {

        }


    }
}
