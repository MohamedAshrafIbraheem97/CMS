using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.BL;

namespace CMS.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValidate()
        {
            // -- Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(3)
            {
                ProductName = "Oranges",
                CurrentPrice = 5,
                Description = "this is oranges"
            };

            // -- Act
            var actual = productRepository.Retrieve(3);

            // -- Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // -- Arrange
            var productRepo = new ProductRepository();

            var updateProduct = new Product(3)
            {
                ProductName = "millon",
                Description = "this is millon",
                CurrentPrice = 66,
                HasChanges = true
            };

            // -- Act
            var actual = productRepo.Save(updateProduct);

            //-- Assert

            Assert.AreEqual(true, actual);



        }
    }
}
