using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class Customer : EntityBase
    {
        #region Interface
        public string log() => $"{CustomerId}:{FullName} Email: {Email}";
        #endregion Interface

        // constructor chaining
        public Customer() : this(0) { }
        public Customer(int _customerId) { CustomerId = _customerId; }

        #region properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }

        public int CustomerType { get; set; } // Inheritance or these


        #endregion properties
        
        #region methods

        #endregion methods

        #region Leverage
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;
            return isValid;
        }
        #endregion Leverage


    }
}
