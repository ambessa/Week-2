using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test_NumberOfDvdInStock_CallsReadQuantityOfDatabaseReader_WhenCalled()
        {
            //Arrange
            Mock<DatabaseReader> mockDatabaseReader = new Mock<DatabaseReader>();
            StockChecker stockChecker = new StockChecker(mockDatabaseReader.Object);

            //Act
            stockChecker.NumberOfDvdsInStock();

            //Assert
            mockDatabaseReader.Verify(r => r.ReadQuantity());
        }
    }
}
