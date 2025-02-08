namespace Employee_Management_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTime employee1 = new FullTime(12345, "John Doe", "Maintenance", 45000);//This creates a new fulltime employee object with the needed properties filled in.
            employee1.CalculatePay();//Calls the CalculatePay method
            employee1.DisplayEmployeeDetails();//Calls the DisplayEmployeeDetails method.

            PartTime employee2 = new PartTime(23456, "Joe Sickspak", "Food Services");//Creation of new part time employee object.
            employee2.CalculatePay();
            employee2.DisplayEmployeeDetails();

            Contractor employee3 = new Contractor(34567, "Farr Better Plumbing", "Contractor");//Creation of new contractor object.
            employee3.CalculatePay();
            employee3.DisplayEmployeeDetails();

        }
    }
}
