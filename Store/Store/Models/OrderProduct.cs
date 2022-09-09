using Microsoft.EntityFrameworkCore;

namespace Store.Models
{
    
    public class OrderProduct
    {

 

       

        public Order Order { get; set; }

        public int OrderId { get; set; }
        /// <summary>
        /// /////////////////////////////////////
        /// </summary>
        public Product Product { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }

       

        public OrderProduct()
        {
            Quantity = 0;
           
        }
    }
}
