// Prints the title of the program to the screen.
Console.WriteLine("Anonymous Income Comparison Program");

// Prints the heading for Person 1.
Console.WriteLine("Person 1");

// Asks the user for Person 1's hourly rate and converts the input to a decimal number.
Console.WriteLine("Hourly Rate?");
decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());

// Asks the user how many hours Person 1 works per week and converts the input to a decimal number.
Console.WriteLine("Hours worked per week?");
decimal person1HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

// Prints the heading for Person 2.
Console.WriteLine("Person 2");

// Asks the user for Person 2's hourly rate and converts the input to a decimal number.
Console.WriteLine("Hourly Rate?");
decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());

// Asks the user how many hours Person 2 works per week and converts the input to a decimal number.
Console.WriteLine("Hours worked per week?");
decimal person2HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

// Calculates Person 1's annual salary by multiplying their hourly rate by their weekly hours and then by 52 weeks.
decimal person1AnnualSalary = person1HourlyRate * person1HoursPerWeek * 52;

// Calculates Person 2's annual salary by multiplying their hourly rate by their weekly hours and then by 52 weeks.
decimal person2AnnualSalary = person2HourlyRate * person2HoursPerWeek * 52;

// Prints the label for Person 1's annual salary.
Console.WriteLine("Annual salary of Person 1:");

// Displays Person 1's calculated annual salary.
Console.WriteLine(person1AnnualSalary);

// Prints the label for Person 2's annual salary.
Console.WriteLine("Annual salary of Person 2:");

// Displays Person 2's calculated annual salary.
Console.WriteLine(person2AnnualSalary);

// Prints the question asking whether Person 1 earns more money than Person 2.
Console.WriteLine("Does Person 1 make more money than Person 2?");

// Compares the two annual salaries and displays either True or False.
Console.WriteLine(person1AnnualSalary > person2AnnualSalary);