using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MondayPractice1;
using System.Collections.Generic;


namespace BookStoreTDD
{
    [TestClass]
    public class CheckoutTest
    {
        [TestMethod]
        public void Test_CalculatePrice_ReturnsDoubleZeroPointZeroWhenPassedAnEmptyBasket()
        {
            //Arrange
            Basket basketContent = new Basket(new List<Book>());
            Checkout checkoutContent = new Checkout();
            
            //Act
            double totalCheckoutPrice = checkoutContent.calculatePrice(basketContent);

            //Assert
            Assert.AreEqual(0.0, totalCheckoutPrice);
        }

        [TestMethod]
        public void Test_CalculatePrice_ReturnsPriceOfBookInBasket_WhenPassedBasketWithOneBook()
        {
            //Arrange
            Basket basketContent = new Basket(new List<Book>());
            basketContent.AddBook();
            Checkout checkoutContent = new Checkout();

            //Act
            double totalCheckoutPrice = checkoutContent.calculatePrice(basketContent);

            //Assert
            Assert.AreEqual(10, totalCheckoutPrice);
        }

        [TestMethod]
        public void Test_CalculatePrice_ReturnsPriceOfBooksInBasket_WhenPassedBasketWithTwoBooks()
        {
            //Arrange
            Basket basketContent = new Basket(new List<Book>());
            basketContent.AddBook();
            basketContent.AddBook();
            Checkout checkoutContent = new Checkout();

            //Act
            double totalCheckoutPrice = checkoutContent.calculatePrice(basketContent);

            //Assert
            Assert.AreEqual(20, totalCheckoutPrice);
        }

        [TestMethod]
        public void Test_CalculatePrice_ReturnsPriceOfBooksInBasket_WhenPassedBasketWithThreeBooksReturnsPriceMinusOnePercent()
        {
            //Arrange
            Basket basketContent = new Basket(new List<Book>());
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            Checkout checkoutContent = new Checkout();

            //Act
            double totalCheckoutPrice = checkoutContent.calculatePrice(basketContent);

            //Assert
            Assert.AreEqual(30*0.99, totalCheckoutPrice);
        }

        [TestMethod]
        public void Test_CalculatePrice_ReturnsPriceOfBooksInBasket_WhenPassedBasketWithSevenBooksReturnsPriceMinusTwoPercent()
        {
            //Arrange
            Basket basketContent = new Basket(new List<Book>());
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            Checkout checkoutContent = new Checkout();

            //Act
            double totalCheckoutPrice = checkoutContent.calculatePrice(basketContent);

            //Assert
            Assert.AreEqual(70 * 0.98, totalCheckoutPrice);
        }

        [TestMethod]
        public void Test_CalculatePrice_ReturnsPriceOfBooksInBasket_WhenPassedBasketWithTenBooksReturnsPriceMinusTenPercent()
        {
            //Arrange
            Basket basketContent = new Basket(new List<Book>());
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            basketContent.AddBook();
            Checkout checkoutContent = new Checkout();

            //Act
            double totalCheckoutPrice = checkoutContent.calculatePrice(basketContent);

            //Assert
            Assert.AreEqual(100 * 0.90, totalCheckoutPrice);
        }
    }
}
