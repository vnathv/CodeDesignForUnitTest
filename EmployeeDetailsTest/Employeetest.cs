using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeDetailsBL;
using DataAccessLayer;
using Entities;
using Moq;

namespace EmployeeDetailsTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void GivenIPassFirstNameAndLastNameThenIShouldgetFullName_WithMOQ()
        {
            //arrange
            Mock<IEmployeeDetail> mockEmployee = new Mock<IEmployeeDetail>();
            mockEmployee
                .Setup(a => a.GetEmployeeDetails())
                .Returns(new Employee { FirstName = "Hello", LastName = "CodeWithVijay" });

            EmployeeDetail objEmployeeDetail = new EmployeeDetail(mockEmployee.Object);

            //act
            var actualResult = objEmployeeDetail.GetFullName();

            //assert
            Assert.AreEqual("Hello CodeWithVijay", actualResult);
        }
        [TestMethod]
        public void GivenIPassFirstNameAndLastNameThenIShouldgetFullName_WithManualMock()
        {
            //arrange
            IEmployeeDetail mockEmployee = new ManualMock();

            EmployeeDetail objEmployeeDetail = new EmployeeDetail(mockEmployee);

            //act
            var actualResult = objEmployeeDetail.GetFullName();

            //assert
            Assert.AreEqual("Vijayanath Viswanathan", actualResult);
        }
    }

    public class ManualMock : IEmployeeDetail
    {
        public Employee GetEmployeeDetails()
        {
            return new Employee
            {
                FirstName = "Vijayanath",
                LastName = "Viswanathan"
            };
        }
    }


}
