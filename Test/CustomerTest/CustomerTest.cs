using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.BL;

namespace CustomerTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ValidCustomerName()
        {
            // -- Arrange
            var customer = new Customer {
                FirstName = "Mohamed",
                LastName = "Ashraf"
            };

            var expected = "Ashraf, Mohamed";
            // -- Act
            var actual = customer.FUllName;
            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidCustomerfirstName()
        {
            // -- Arrange
            var customer = new Customer
            {
                FirstName = "Mohamed"
            };

            var expected = "Mohamed";
            // -- Act
            var actual = customer.FUllName;
            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InvalidCustomerlastName()
        {
            // -- Arrange
            var customer = new Customer
            {
                LastName = "Ashraf"
            };

            var expected = "Ashraf";
            // -- Act
            var actual = customer.FUllName;
            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckValidateMethod()
        {
            // -- Arrange
            var customer = new Customer
            {
                EmailAddress = "Mohamed@gmail.com"
            };

            var expected = customer.Validate();
            // -- Act
            var actual = false;
            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
