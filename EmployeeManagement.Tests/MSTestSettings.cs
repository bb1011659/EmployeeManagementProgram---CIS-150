using Employee_Management_Program;

namespace EmployeeManagementTests
{
    [TestClass]

    public class CalculatePayTests
    {
        [TestMethod]
        
        public void CalculatePay_ShouldReturnBaseSalaryPlusAnnualBonus()
        {
            var employee1 = new FullTime(12345, "Gavin Newsome", "Public Works", 66600);

            Assert.AreEqual(69930, (FullTime.BaseSalary + FullTime.AnnualBonus))
        }
    }
}