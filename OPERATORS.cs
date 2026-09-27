using System; // Imports the System namespace so we can use Console.WriteLine().

// Creates an Employee class to represent an employee.
class Employee
{
// Creates an integer property to store the employee's ID number.
public int Id { get; set; }

// Creates a string property to store the employee's first name.
public string FirstName { get; set; }

// Creates a string property to store the employee's last name.
public string LastName { get; set; }


// Overloads the == operator so two Employee objects can be compared.
// The two Employee objects are considered equal if their Id properties are equal.
public static bool operator ==(Employee employee1, Employee employee2)
{
    // Compares the Id of the first Employee with the Id of the second Employee.
    // Returns true if the Id values are the same.
    return employee1.Id == employee2.Id;
}


// Overloads the != operator because comparison operators must be overloaded in pairs.
// The != operator checks if two Employee objects have different Id values.
public static bool operator !=(Employee employee1, Employee employee2)
{
    // Returns the opposite result of the == operator.
    // Returns true when the two Employee Id values are different.
    return employee1.Id != employee2.Id;
}

}

// Creates the Program class that contains the Main() method.
class Program
{
// The Main() method is where the program begins running.
static void Main(string[] args)
{
// Creates the first Employee object.
Employee employee1 = new Employee();

    // Assigns an ID of 1 to the first Employee.
    employee1.Id = 1;

    // Assigns "John" as the first name of the first Employee.
    employee1.FirstName = "John";

    // Assigns "Smith" as the last name of the first Employee.
    employee1.LastName = "Smith";


    // Creates the second Employee object.
    Employee employee2 = new Employee();

    // Assigns an ID of 2 to the second Employee.
    employee2.Id = 2;

    // Assigns "Jane" as the first name of the second Employee.
    employee2.FirstName = "Jane";

    // Assigns "Doe" as the last name of the second Employee.
    employee2.LastName = "Doe";


    // Uses the overloaded == operator to compare the two Employee objects.
    // The result is stored in a bool variable.
    bool employeesAreEqual = employee1 == employee2;

    // Displays whether the two Employee objects have the same Id.
    Console.WriteLine("Are the employees equal? " + employeesAreEqual);


    // Uses the overloaded != operator to compare the two Employee objects.
    // The result is stored in another bool variable.
    bool employeesAreNotEqual = employee1 != employee2;

    // Displays whether the two Employee objects have different Id values.
    Console.WriteLine("Are the employees different? " + employeesAreNotEqual);


    // Keeps the console window open until the user presses Enter.
    Console.ReadLine();
}

}
