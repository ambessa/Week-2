using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzProgram;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTest
    {
        FizzBuzzer myFizzBuzzer;

        [TestInitialize]
        public void Setup()
        {
            myFizzBuzzer = new FizzBuzzer();
        }

        [TestMethod]
        public void Test_FizzBuzz_ReturnsOne_WhenOneIsInput()
        {
            //Arrange
            
            //Act
            int number = myFizzBuzzer.FizzBuzz(1);
            
            //Assert
            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void Test_FizzBuzz_ReturnsTwo_WhenTwoIsInput()
        {
            //Arrange
 
            //Act
            int number = myFizzBuzzer.FizzBuzz(2);

            //Assert
            Assert.AreEqual(2, number);
        }

        [TestMethod]
        public void Test_FizzBuzz_ReturnsThree_WhenThreeIsInput()
        {
            //Arrange

            //Act
            int number = myFizzBuzzer.FizzBuzz(3);

            //Assert
            Assert.AreEqual(3, number);
        }
    }
}
