namespace Employee_Management_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
             FullTime employee1 = new FullTime(12345, "John Doe", "Maintenance", 45000, 6);//This creates a new fulltime employee object with the needed properties filled in.
             employee1.CalculatePay();//Calls the CalculatePay method
             employee1.DisplayEmployeeDetails();//Calls the DisplayEmployeeDetails method.

             PartTime employee2 = new PartTime(23456, "Joe Sickspak", "Food Services", 15.50, 35);//Creation of new part time employee object.
             employee2.CalculatePay();
             employee2.DisplayEmployeeDetails();

             Contractor employee3 = new Contractor(34567, "Farr Better Plumbing", "Contractor", 50000);//Creation of new contractor object.
             employee3.CalculatePay();
             employee3.DisplayEmployeeDetails();

            FullTime employee4 = new FullTime(67895, "Kylee Brown", "Finance", 250000, 15);
            employee4.CalculatePay();
            employee4.DisplayEmployeeDetails();

            PartTime employee5 = new PartTime(7648, "Blake Brown", "House Keeping", 15.75, 24);
            employee5.CalculatePay();
            employee5.DisplayEmployeeDetails();

            Contractor employee6 = new Contractor(43567, "PlumbRite", "Maintenance", -1000);
            employee6.CalculatePay();
            employee6.DisplayEmployeeDetails();

        }
    }
}
