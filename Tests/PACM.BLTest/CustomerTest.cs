using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;

namespace PACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            //Variable to hold the expected result when actually 
            string expected = "Baggins, Bilbo";

            //-- Act
            //Performing test
            string actual = customer.FullName;
            
            //-- Assert
            //verifying the expected value equals the actual value
            Assert.AreEqual(expected, actual);
        }
    }
}