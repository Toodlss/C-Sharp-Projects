using System; // Imports the System namespace so we can use basic C# functionality.
using System.Collections.Generic; // Imports the namespace needed to use List<T>.
using System.Linq; // Imports the namespace needed to use lambda expressions with Where().

// Creates an Employee class to represent an employee.
class Employee
{
// Creates an integer property to store the employee's ID.
public int Id { get; set; }

// Creates a string property to store the employee's first name.
public string FirstName { get; set; }

// Creates a string property to store the employee's last name.
public string LastName { get; set; }

}

// Creates the Program class that contains the Main() method.
class Program
{
// The Main() method is where the program begins running.
static void Main(string[] args)
{
// Creates a list of Employee objects.
// The list contains 10 employees, including two employees named Joe.
List<Employee> employees = new List<Employee>
{
// Creates the first Employee and assigns values to its properties.
new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },

        // Creates the second Employee.
        new Employee { Id = 2, FirstName = "John", LastName = "Doe" },

        // Creates the third Employee.
        new Employee { Id = 3, FirstName = "Sarah", LastName = "Johnson" },

        // Creates the fourth Employee.
        new Employee { Id = 4, FirstName = "Mike", LastName = "Brown" },

        // Creates the fifth Employee.
        new Employee { Id = 5, FirstName = "Emily", LastName = "Davis" },

        // Creates the sixth Employee.
        new Employee { Id = 6, FirstName = "Joe", LastName = "Williams" },

        // Creates the seventh Employee.
        new Employee { Id = 7, FirstName = "David", LastName = "Miller" },

        // Creates the eighth Employee.
        new Employee { Id = 8, FirstName = "Jessica", LastName = "Wilson" },

        // Creates the ninth Employee.
        new Employee { Id = 9, FirstName = "Chris", LastName = "Moore" },

        // Creates the tenth Employee.
        new Employee { Id = 10, FirstName = "Amanda", LastName = "Taylor" }
    };


    // Creates an empty list that will hold employees whose first name is Joe.
    List<Employee> joeEmployees = new List<Employee>();

    // Uses a foreach loop to go through every employee in the employees list.
    foreach (Employee employee in employees)
    {
        // Checks the FirstName property of the current Employee object.
        // If the first name is "Joe", that Employee is added to the new list.
        if (employee.FirstName == "Joe")
        {
            // Adds the Employee object to the joeEmployees list.
            joeEmployees.Add(employee);
        }
    }


    // Displays a heading for the employees found using the foreach loop.
    Console.WriteLine("Employees named Joe using foreach:");

    // Loops through the list of employees named Joe.
    foreach (Employee employee in joeEmployees)
    {
        // Displays the employee's ID, first name, and last name.
        Console.WriteLine(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
    }


    // Uses a lambda expression to create another list containing employees named Joe.
    // "employee => employee.FirstName == \"Joe\"" checks the FirstName property.
    List<Employee> joeEmployeesLambda = employees
        .Where(employee => employee.FirstName == "Joe")
        .ToList();


    // Displays a heading for the employees found using the lambda expression.
    Console.WriteLine("\nEmployees named Joe using lambda:");

    // Loops through the list created using the lambda expression.
    foreach (Employee employee in joeEmployeesLambda)
    {
        // Displays the employee's ID, first name, and last name.
        Console.WriteLine(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
    }


    // Uses a lambda expression to create a list of employees whose Id is greater than 5.
    // The expression checks the Id property of each Employee object.
    List<Employee> employeesOverFive = employees
        .Where(employee => employee.Id > 5)
        .ToList();


    // Displays a heading for employees with an Id greater than 5.
    Console.WriteLine("\nEmployees with an Id greater than 5:");

    // Loops through the list of employees whose Id is greater than 5.
    foreach (Employee employee in employeesOverFive)
    {
        // Displays the employee's ID, first name, and last name.
        Console.WriteLine(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
    }


    // Keeps the console window open until the user presses Enter.
    Console.ReadLine();
}

}
