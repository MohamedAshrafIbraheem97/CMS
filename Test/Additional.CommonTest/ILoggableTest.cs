using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Additional.Common;
using CMS.BL;

namespace Additional.CommonTest
{
    [TestClass]
    public class ILoggableTest
    {
        [TestMethod]
        public void ILoggableValidTest()
        {
            // -- Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                FirstName = "mohamed",
                LastName = "ashraf",
                EmailAddress = "mohamed@gmail.com"
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "orange",
                Description = "this is orange"
            };

            changedItems.Add(product);
            // -- Act
            LoggingService.writeToFile(changedItems);
            // -- Assert
        }
    }
}
