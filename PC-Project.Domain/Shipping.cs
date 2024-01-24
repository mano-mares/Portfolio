using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Domain
{
    public class Shipping
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ShippingMethod { get; set; }
        public decimal Cost { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        
        public virtual Order Order {  get; set; }
    }
}
