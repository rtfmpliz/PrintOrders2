using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOrders2
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total 
        {
            get 
            {
                return Quantity * UnitPrice - Quantity * UnitPrice * Discount;
            }
        }
    }
}
