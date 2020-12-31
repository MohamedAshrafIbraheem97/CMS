using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Additional.Common;

namespace Additional.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // -- Arrange

            var source = "Good Orange";

            var expected = "Good Orange";


            // -- Act
            var actual = StringHandler.InsertSpaces(source);

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
