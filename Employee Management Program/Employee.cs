using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Program
{
    public class Employee
    {   //These four properties are kept private and lower case to encapsulate their data. They are exposed publicly starting on line 17.
        private int id;
        private string name;
        private string department;
        private double baseSalary;
        

        public int ID //This exposes the private property id as a public property called ID.
        {
            get { return id; } //This line and the next are the get and set actions that are used to get the value of id and set it within the program.
            set { id = value; }
        }

        public string Name//This exposes the name property.
        {
            get { return name; }//Same idea as lines 19 and 20.
            set { name = value; }
        }

        public string Department//This exposes the department property.
        {
            get { return department; }
            set { department = value; }
        }

        public double BaseSalary//This exposes the baseSalary property.
        {
            get { return baseSalary; }
            set { baseSalary = value; }

        }

        public Employee (int id, string name, string department, double baseSalary)//This is the constructor that sets up the information we will need when instantiating a new Employee object.
        {
            ID = id;
            Name = name;
            Department = department;
            BaseSalary = baseSalary;
        }

        public virtual void CalculatePay()//This is the creation of the CalculatePay method that we will use to calculate the pay of each type of employee. It is made vitural so we can override the method in our inherited classes.
        {
            double totalPay = baseSalary;

        }

        public virtual void DisplayEmployeeDetails()//Same idea as the CalculatePay method, but for DisplayEmployeeDetails method instead.
        {
            Console.WriteLine(ToString());//This allows us to call an overridden ToString method in our inherited classes through the DisplayEmployeeDetails method.
        }
    }

    public class FullTime : Employee//This shows that FullTime is an inherited class from the Employee base class.
    {
        private double annualBonus;//This adds the custom property of annualBonus that is exclusive to the FullTime inherited class.
        public double AnnualBonus//This exposes the private property seen above.
        {
            get { return annualBonus; }
            set { annualBonus = value; }
        }

        public FullTime (int id, string name, string department, double baseSalary) : base (id, name, department, baseSalary)//This is the custom constructor for our FullTime class.
        {
            AnnualBonus = BaseSalary * .05;//This tells the program to calculate the FullTime employee's bonus as 5% of their base salary.
        }

        public override void CalculatePay()//The override key word is used because we are changing the CalculatePay method for the fulltime employee.
        {
           
            double totalPay = BaseSalary + AnnualBonus;//This includes Annual Bonus in the calculation of total pay.
            Console.WriteLine($"{Name}'s total pay this year was ${totalPay}.\n ");//This informs the user what the pay was for this employee. That includes base salary and annual bonus.
        }

       

        public override string ToString()//The code below is the information that will be displayed when the DisplayEmployeeDetails method is called for this employee.
        {
            return $"ID: {ID}\nName: {Name}\nDepartment: {Department}\nBaseSalary: {BaseSalary}\nAnnual Bonus: {AnnualBonus}\n ";
        }
    }

    public class PartTime : Employee
    {
        private double hourlyRate;//This property and the property below are custom properties for only part time employees.
        private int hoursWorked;

        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }
        public PartTime (int id, string name, string department) : base (id, name, department, 0)//Value of zero is used for baseSalary because part time employees don't have a base Salary, thus the property is not used.
        {
            Console.Write($"What is the current hourly rate for {Name}?\n>>");//This asks the user to input the hourly rate for the given employee.
            HourlyRate = Convert.ToDouble(Console.ReadLine());//This converts the user's input to type double.
            Console.Write($"How many hours has {Name}, Employee ID#{ID} worked during the current pay period?\n>>");//This asks the user to input the amount of hours worked during the current pay period.
            HoursWorked = Convert.ToInt32(Console.ReadLine());//This converts the hours input into type int.
        }

        public override void CalculatePay()
        {
            
            
            double totalPay = HourlyRate * HoursWorked;//This is the new calculation for calculating the pay for part time employees.
            Console.WriteLine($"{Name}'s total pay for this pay period is ${totalPay:N2}.\n ");

        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nDepartment: {Department}\nHourly Rate: {HourlyRate}\nHours Worked: {HoursWorked}\n ";
        }
    }

    public class Contractor : Employee
    {
        private DateTime contractExpiryDate;//This is a custom property for Contractors.
        private double contractAmount;//This is a custom property for Contractors.
        public DateTime ContractExpiryDate
        {
            get { return contractExpiryDate; }
            set { contractExpiryDate = value; }
        }
        public double ContractAmount
        {
            get { return contractAmount; }
            set { contractAmount = value; }
        }
        public Contractor (int id, string name, string department) : base (id, name, department, 0)//Value of zero is used for baseSalary because contractors don't have a base Salary, thus the property is not used.
        {
            Console.Write($"When is the Contract for {Name} set to expire? Please enter MM/DD/YYYY\n<<");//This ask the user to input when the contract is set to expire, and how to input the date.
            ContractExpiryDate = Convert.ToDateTime(Console.ReadLine());//Converts the user input to type DateTime.


        }
        
        public override void CalculatePay()
        {
            if(DateTime.Today >= ContractExpiryDate)//Contractors aren't paid until the job is done, which we will assume is the expiry date. This if statement says if the current date is past or equal to the expiry date, then the contractor is paid.
            {
                ContractAmount = 10000;
            }
            else//This condition occurs when the current date is before the expiry date. The presumption is the job is not done before the expiry date, so the contractor is not paid yet.
            {
                Console.WriteLine($"Contract for {Name} is not set to expire until {ContractExpiryDate}.\nNo payment is due until then.");
                ContractAmount = 0;
            }
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nDepartment: {Department}\nContract Expiry Date: {ContractExpiryDate}\nContract Amount: {ContractAmount}";
        }
    }
}
