using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionsExampleDay3;
using System.Collections.Generic;

namespace Collections
{
    [TestClass]
    public class CollectionTest
    {

        [TestMethod]
        public void Test_GetRandomEmployee_ReturnsAnEmployee_WhenGivenAListOfEmployees()
        {
            //arrange
            PrizeGenerator prizeGenerator = new PrizeGenerator();
            List<Employee> employees = new List<Employee>() { new Employee(), new Employee(), new Employee() };
                                                                            
            //act
            Employee winningEmpolyee = prizeGenerator.GetRandomEmployee(employees);

            //assert
            Assert.IsInstanceOfType(winningEmpolyee, typeof(Employee));
        }

        [TestMethod]
        public void Test_GetEmployeesNames_ReturnNameCount_WhenGivenAListOfEmployees()
        {
            //arrange
            EmployeeNameCount empNameCount = new EmployeeNameCount();

            Employee employee1 = new Employee();
            employee1.firstName = "Abel";
            Employee employee2 = new Employee();
            employee2.firstName = "Abel";
            Employee employee3 = new Employee();
            employee3.firstName = "Dan";

            List<Employee> employees = new List<Employee>() { employee1, employee2, employee3 };

            //act
            Employee popularFirstName = empNameCount.GetEmployeesNames(employees);

            //assert
            Assert.IsInstanceOfType(popularFirstName, typeof(Employee));
        }

        //[TestMethod]
        //public void test_GetEmployeesNames_GivenThisMonth_ThenChooseToyWinner()
        //{
        //    //arrange
        //    Employees emp1 = new Employees();

        //    //act
        //    List<Employees> listOfEmployees = new List<Employees>();
        //    emp1.getEmployeesNames();
            
        //    //assert
        //    Assert.AreEqual(0, listOfEmployees.Count);
        //}
        //[TestMethod]
        //public void test_GetEmployeesNames_GivenEachMonth_ThenChooseToyWinner()
        //{
        //    //arrange
        //    Employees emp1 = new Employees();

        //    //act
        //    List<Employees> listOfEmployees = new List<Employees>();
        //    emp1.getEmployeesNames();
        //    //assert
        //    Assert.AreEqual(0, listOfEmployees.Count);
        //}
    }
}
