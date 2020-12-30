using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    class Order : EntityBase
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItemsList = new List<OrderItem>();
        }
        public int OrderId { get; private set; }
        public int customerId { get; set; }
        public int addressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItemsList { get; set; }

        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null ) isValid = false;

            return isValid;
        }

    }
}
