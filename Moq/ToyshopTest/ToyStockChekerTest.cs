using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toyshop;
using Moq;

namespace ToyshopTest
{
    [TestClass]
    public class ToyStockChekerTest
    {
        [TestMethod]
        public void test_CheckNumberInStock_CallsReadQuantityMethodOfDatabaseReader_WhenItsCalled()
        {
            //Arrange
            Mock<DataBaseReader> mockDBReader = new Mock<DataBaseReader>();
            StockChecker stockChecker = new StockChecker(mockDBReader.Object);
            //Act
            int numberOfStock = stockChecker.CheckNumberInStock(1);//we are testing behaviour we dont need integer
            //Assert
            mockDBReader.Verify(r => r.ReadQuantity(It.IsAny<int>()));
        }
        [TestMethod]
        public void test_CheckNumberInStock_ReturnsThree_WhenThreeCopiesExist()
        {
            //Arrange
            Mock<DataBaseReader> mockDBReader = new Mock<DataBaseReader>();
            StockChecker stockChecker = new StockChecker(mockDBReader.Object);
            mockDBReader.Setup(r => r.ReadQuantity(It.IsAny<int>())).Returns(3);
            //Act
            int numberOfStock = stockChecker.CheckNumberInStock(1);
            //Assert
            Assert.AreEqual(3, numberOfStock);
        }
    }

}
