using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MondayPractice1;
using System.Collections.Generic;

namespace BookStoreTDD
{
    [TestClass]
    public class BasketTest
    {
        [TestMethod]
        public void Test_GetBooksInBasket_ReturnsEmptyBookList_IfNoBookshaveBeenAdded()
        {
            //Arrange
            Basket basketContent = new Basket(new List<Book>());

            //Act
            List<Book> listOfBooks = basketContent.getBooksInBasket();

            //Assert
            Assert.AreEqual(0, listOfBooks.Count);
        }

        [TestMethod]
        public void Test_GetBooksInBasket_ArrayOfLengthOne_AfterAddBookMethodIsCalledWithOneBook()
        {
            //Arrange
            Basket basketContent = new Basket(new List<Book>());
            basketContent.AddBook();
                      
            //Act
            List<Book> listOfBooks = basketContent.getBooksInBasket();
            
            //Assert
            Assert.AreEqual(1, listOfBooks.Count);
        }

        [TestMethod]
        public void Test_GetBooksInBasket_ArrayOfLengthTwo_AfterAddBookMethodIsCalledWithTwoBooks()
        {
            //Arrange
            Basket basketContent = new Basket(new List<Book>());
            basketContent.AddBook();
            basketContent.AddBook();

            //Act
            List<Book> listOfBooks = basketContent.getBooksInBasket();

            //Assert
            Assert.AreEqual(2, listOfBooks.Count);
        }
    }
}
