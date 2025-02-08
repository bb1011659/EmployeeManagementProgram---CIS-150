Welcome to the Employee Management Program!
This program is set up to calculate the pay of your employee(s) based on their employment classification.
This program is also set up to display the information of the given employee after their pay has been calculated.

To utilize the methods stated above, simply instantiate a new employee object, and fill in the properties with the necessary information.
Example:Full Time Employee
	FullTime employee1 = new FullTime(12345, "Jim Carey", "Entertainment", 100000, 6);
	The properties that need to be filled in for full time employees are their ID number, their name, their department, base salary, and the percentage of their annual bonus.
	In the example above, the employee is receiving a 6% bonus. Input a whole number, and it will be converted into a percentage in the program.

Example:Part Time Employee
	PartTime employee2 = new PartTime(23456, "Gerard Butler", "Hospitality", 15.50, 35);
	The properties that need to be filled in for part time employees are their ID number, their name, their department, their hourly rate, and their hours worked in the current pay period.

Example: Contractors
	Contractor employee3 = new Contractor(34567, "Black Rock Financial Group", "Contractor", 150000);
	The properties that need to be filled in for contractors are their ID number, the name of the contractors business, the title of contractor, and the contract amount.
	The expiry date of the contract will be input in the CalculatePay method. 
