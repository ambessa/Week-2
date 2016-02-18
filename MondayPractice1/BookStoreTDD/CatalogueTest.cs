using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MondayPractice1;
using System.Collections.Generic;
using Moq;

namespace BookStoreTDD
{
    [TestClass]
    public class CatalogueTest
    {
        [TestMethod]
        public void Test_GetAllBooks_ReturnsEmptyBookList_IfNoBooksAreInTheCatalogue()
        {
            //Arrange
            Catalogue catalogue = new Catalogue(new ReadDatabase(),new WriteDataBase());
            

            //Act
            List<Book> emptyBookList = catalogue.GetAllBooks();

            //Assert
            Assert.AreEqual(0, emptyBookList.Count);

        }

        [TestMethod]
        public void Test_GetAllBooks_CallsReadAllMethodOfReadItemCommand_WhenCalled()
        {
            //Arrange
            Mock<ReadDatabase> mockReadDataBase = new Mock<ReadDatabase>();
            Mock<WriteDataBase> writeDataBase = new Mock<WriteDataBase>();
            Catalogue catalogue = new Catalogue(mockReadDataBase.Object, writeDataBase.Object);

            //Act
            List<Book> emptyBookList = catalogue.GetAllBooks();

            //Assert
            mockReadDataBase.Verify(r => r.ReadAll());
        }

        [TestMethod]
        public void Test_GetAllBooks_ReturnsListOfBooksItRecievesFromReadAllMethodOfReadAllCommand_WhenCalled()
        {
            //Arrange
            Mock<ReadDatabase> mockReadDataBase = new Mock<ReadDatabase>();
            Mock<WriteDataBase> writeDataBase = new Mock<WriteDataBase>();
            Catalogue catalogue = new Catalogue(mockReadDataBase.Object, writeDataBase.Object);
            List<Book> myList = new List<Book>();
            mockReadDataBase.Setup(r => r.ReadAll()).Returns(myList);
            

            //Act
            List<Book> emptyBookList = catalogue.GetAllBooks();

            //Assert
            CollectionAssert.AreEqual(emptyBookList,myList);
        }

        [TestMethod]
        public void Test_AddBook_CallsInsertBookMethodOfWriteDataBase_WhenCalled()
        {
            //Arrange
            Mock<ReadDatabase> mockReadDataBase = new Mock<ReadDatabase>();
            Mock<WriteDataBase> writeDataBase = new Mock<WriteDataBase>();
            Catalogue catalogue = new Catalogue(mockReadDataBase.Object,writeDataBase.Object);
            

            //Act
            catalogue.AddBook(new Book());

            //Assert
            writeDataBase.Verify(a => a.InsertBook(It.IsAny<Book>()));

        }

        [TestMethod]
        public void Test_AddBook_PassBookSentToInsertBookMethodWriteDataBase_WhenCalled()
        {
            //Arrange
            Book bookToAdd = new Book();
            bookToAdd.id = 2;

            Mock<ReadDatabase> mockReadDataBase = new Mock<ReadDatabase>();
            Mock<WriteDataBase> writeDataBase = new Mock<WriteDataBase>();
            Catalogue catalogue = new Catalogue(mockReadDataBase.Object,writeDataBase.Object);
 
            //Act
            catalogue.AddBook(bookToAdd);
            
            //Assert
            writeDataBase.Verify(a => a.InsertBook(It.Is<Book>(b => b.id == 2)));
        }

    }
}
