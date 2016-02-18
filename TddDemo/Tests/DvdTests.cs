using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddDemo;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class DvdTests
    {
        [TestMethod]
        public void Test_GetAllDvds_ReturnAListOfLengthZero_WhenTheDatabaseHasNoDvds()
        {
            //Arrange
            Database databaseOfDvds = new Database();
            databaseOfDvds.listOfDvds = new List<Dvd>();

            //Act
            List<Dvd> listOfDvds = databaseOfDvds.GetAllDvds();

            //Assert
            Assert.AreEqual(0, listOfDvds.Count);
        }

        [TestMethod]
        public void Test_GetAllDvds_ReturnAListOfLengthOne_WhenTheDatabaseHasOneDvd() 
        {
            //Arrange
            Database databaseOfDvds = new Database();
            databaseOfDvds.listOfDvds = new List<Dvd>() { new Dvd() };
            
            //Act
            List<Dvd> listOfDvds = databaseOfDvds.GetAllDvds();

            //Assert
            Assert.AreEqual(1, listOfDvds.Count);
        }

        [TestMethod]
        public void Test_GetAllDvds_ReturnAListOfLengthTwo_WhenTheDatabaseHasTwoDvds()
        {
            //Arrange
            Database databaseOfDvds = new Database();
            databaseOfDvds.listOfDvds = new List<Dvd>() { new Dvd(), new Dvd() };

            //Act
            List<Dvd> listOfDvds = databaseOfDvds.GetAllDvds();

            //Assert
            Assert.AreEqual(2, listOfDvds.Count);
        }

        [TestMethod]
        public void Test_AddDvd_ReturnsAListOfLengthOne_WhenOneDvdIsAdded()
        {
            //Arrange
            Database databaseOfDvds = new Database();
            databaseOfDvds.listOfDvds = new List<Dvd>();
            
            //Act
            List<Dvd> listOfDvds = databaseOfDvds.AddDvd();
            
            //Assert
            Assert.AreEqual(1, listOfDvds.Count);
        }
    }
}
