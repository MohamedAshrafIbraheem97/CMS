using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.BL;
using System.Collections.Generic;

namespace CMS.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValidate()
        {
            // -- Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1) {
                FirstName = "Mohamed",
                LastName = "Ashraf",
                EmailAddress = "mohamed@gmail.com"

            };
            // -- Act
            var actual = customerRepository.Retrieve(1);
            // -- Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // -- Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "Mohamed",
                LastName = "Ashraf",
                EmailAddress = "mohamed@gmail.com",
                addressList = new List<Address>()
                {
                    new Address()
                    {
                        StreetLine1 = "str1",
                        StreetLine2 = "str2",
                        CityName = "city1"
                    },
                    new Address()
                    {
                        StreetLine1 = "str11",
                        StreetLine2 = "str22",
                        CityName = "city2"
                    }
                }

            };

            // -- Act
            var actual = customerRepository.Retrieve(1);

            // -- Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            for (int i = 0; i < actual.addressList.Count; i++)
            {
                Assert.AreEqual(expected.addressList[i].StreetLine1, actual.addressList[i].StreetLine1);
                Assert.AreEqual(expected.addressList[i].StreetLine2, actual.addressList[i].StreetLine2);
                Assert.AreEqual(expected.addressList[i].CityName, actual.addressList[i].CityName);

            }


        }
    }
}
