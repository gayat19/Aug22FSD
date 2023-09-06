using EmployeeApp.Services;

namespace EmployeeTest
{
    [TestClass]
    public class EmployeeServiceTest
    {
        [TestMethod]
        public void CountFullTimeEmployeesTest()
        {
            //AAA - > Arrange, Action, Assert

            //Arange
            EmployeeService employeeService = new EmployeeService();

            //Action
            var result = employeeService.CountFullTimeEmployees();
            var data = result % 2;
            //Assert
            Assert.AreEqual(1, data);
        }
    }
}