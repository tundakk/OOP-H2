using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int _productId)
        {
            ProductID = _productId;
        }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductID { get; private set; }
        public decimal? CurrentPrice { get; set; }
        public DateTime? DateCreated { get; set; }

       

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            if(DateCreated == null) isValid = false;
            return isValid;
        }

    }
}
