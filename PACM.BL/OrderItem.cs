using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int _orderItemId)
        {
            OrderItemID = _orderItemId;
        }
        public string ProductId { get; set; }
        public int OrderItemID { get; private set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem retrieve(int productId)
        {
            //Write code to database
            //
            return new OrderItem();
        }
        public bool save()
        {
            //Code that saves the defined product
            return true;
        }

        public bool validate()
        {
            var isValid = true;
            if (Quantity == 0) isValid = false;
            if (ProductId == null) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }

    }
}
