using Xunit;
using Moq;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;


namespace UnitTest
{
    public class EmployeeTest
    {
        #region Property
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        [Fact]
        public async void GetEmployeebyId()
        {
            mock.Setup(p => p.GetEmployeebyId(2)).ReturnsAsync("Bejo");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result = await emp.GetEmployeeById(2);
            Assert.Equal("Bejo", result);
        }

        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new EmployeeItem()
            {
                Id = 2,
                Name = "Bejo",
                Destination ="Kalimantan"
            };

            mock.Setup(p => p.GetEmployeeDetails(2)).ReturnsAsync(employeeDTO);
            EmployeeController emp = new EmployeeController(mock.Object);
            var result = await emp.GetEmployeeDetails(2);
            Assert.True(employeeDTO.Equals(result));
        }
    }
}
