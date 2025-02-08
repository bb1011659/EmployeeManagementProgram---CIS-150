using Employee_Management_Program;

namespace EmployeeManagementTests
{
    [TestClass]

    public class CalculatePayTests
    {
        [TestMethod]

        public void CalculatePay_ShouldReturnBaseSalaryPlusAnnualBonus()
        {
            var employee1 = new FullTime(12345, "Gavin Newsome", "Public Works", 66600, 5);

            Assert.AreEqual(69930, employee1.CalculatePay());
        }

        [TestMethod]
        public void CalculatePay_ShouldReturnOnlyBaseSalary_WhenAnnualBonusIsZero()
        {
            var employee1 = new FullTime(12345, "Bernie Sanders", "Bureacracy", 99999, 0);

            Assert.AreEqual(99999, employee1.CalculatePay());
        }

        [TestMethod]
        public void CalculatePay_ShouldReturnCorrectAmount_WhenGivenHourlyRateAndHours()
        {
            var employee1 = new PartTime(12345, "Thomas Massie", "Engineering", 75.50, 100);

            Assert.AreEqual(7550, employee1.CalculatePay());
        }

        [TestMethod]
        public void CalculatePay_ShouldReturnZero_WhenHoursWorkedIsZero()
        {
            var employee1 = new PartTime(12345, "Pete Buttigieg", "Transportation", 30, 0);

            Assert.AreEqual(0, employee1.CalculatePay());
        }

        [TestMethod]
        public void CalculatePay_ShouldReturnCorrectAmountForContractor()
        {
            var employee1 = new Contractor(12345, "David Boeing", "R&D", 1500000);

            Assert.AreEqual(1500000, employee1.CalculatePay());
        }

        [TestMethod]
        public void CalculatePay_ShouldHandleNegativeValuesGracefully()
        {
            var employee1 = new Contractor(12345, "Everlasting Homes", "Construction", -10000);
            Assert.AreEqual(0, employee1.CalculatePay());
        }
    }

} 