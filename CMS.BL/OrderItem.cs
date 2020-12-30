using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    class OrderItem :EntityBase
    {

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasedPrice { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasedPrice == null) isValid = false;

            return isValid;
        }

        public OrderItem Retrieve(int id)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
