using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    class OrderRepository
    {

        public Order Retrieve(int orderId)
        {
            var order = new Order(5);

            if (orderId == 5)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 2, 2, 12, 12, 12,
                    new TimeSpan(12, 12, 12));
            }

            return order;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
