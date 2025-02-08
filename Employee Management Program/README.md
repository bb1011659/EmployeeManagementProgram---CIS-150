Welcome to the Employee Management Program!
This program is set up to calculate the pay of your employee(s) based on their employment classification.
This program is also set up to display the information of the given employee after their pay has been calculated.

To utilize the methods stated above, simply instantiate a new employee object, and fill in the properties with the necessary information.
Example:Full Time Employee
	FullTime employee1 = new FullTime(12345, "Jim Carey", "Entertainment", 100000);
	The properties that need to be filled in for full time employees are their ID number, their name, their department, and their base salary.

Example:Part Time Employee
	PartTime employee2 = new PartTime(23456, "Gerard Butler", "Hospitality");
	The properties that need to be filled in for part time employees are their ID number, their name, and their department.
	The hourly rate of the employee and the amount of hours worked in the current pay period will be entered in the CalculatePay method.

Example: Contractors
	Contractor employee3 = new Contractor(34567, "Black Rock Financial Group", "Contractor");
	The properties that need to be filled in for contractors are their ID number, the name of the contractors business, and the title of contractor.
	The expiry date of the contract will be input in the CalculatePay method. 
	The employee class is currently set up for the default payment of the contractor to be 10000 for each job. If you wish to change the amount, you can change the value of 10000 on line 156 to any value you desire.
