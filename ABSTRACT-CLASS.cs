using System; // Imports the System namespace so we can use Console.WriteLine().

// Creates an abstract class named Person.
// An abstract class is a class that is meant to be inherited by another class.
abstract class Person
{
// Creates a string property for storing the person's first name.
public string firstName { get; set; }

// Creates a string property for storing the person's last name.
public string lastName { get; set; }

// Declares the SayName() method as abstract.
// This means that any class inheriting from Person must provide its own version of this method.
public abstract void SayName();

}

// Creates the Employee class.
// The ": Person" portion means Employee inherits from the Person class.
class Employee : Person
{
// Implements the SayName() method required by the Person class.
// This method displays the employee's first and last name.
public override void SayName()
{
// Displays the first and last name of the Employee object to the console.
Console.WriteLine("Name: " + firstName + " " + lastName);
}
}

// Creates the main program class that contains the Main() method.
class Program
{
// The Main() method is where the program starts running.
static void Main(string[] args)
{
// Creates a new Employee object.
// The firstName property is set to "Sample".
// The lastName property is set to "Student".
Employee employee = new Employee
{
firstName = "Kaden",
lastName = "Bilyeu"
};

    // Calls the SayName() method on the Employee object.
    // This displays "Name: Sample Student" in the console.
    employee.SayName();

    // Keeps the console window open until the user presses Enter.
    Console.ReadLine();
}

}
