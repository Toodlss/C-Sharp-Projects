using System; // Imports the System namespace so we can use Console.WriteLine().

// Creates an abstract class named Person.
// An abstract class is designed to be inherited by another class.
abstract class Person
{
// Creates a string property for storing the person's first name.
public string firstName { get; set; }

// Creates a string property for storing the person's last name.
public string lastName { get; set; }

// Declares the SayName() method as abstract.

// Any class that inherits from Person must provide an implementation for this method.
public abstract void SayName();
}

// Creates an interface called IQuittable.
// An interface defines a method that a class must implement when it inherits the interface.
interface IQuittable
{
// Declares a void method called Quit().
// The method does not return a value and has no parameters.
void Quit();
}

// Creates the Employee class.
// Employee inherits from the Person class and implements the IQuittable interface.
class Employee : Person, IQuittable
{
// Implements the SayName() method required by the Person class.
public override void SayName()
{
// Displays the employee's first and last name in the console.
Console.WriteLine("Name: " + firstName + " " + lastName);
}

// Implements the Quit() method required by the IQuittable interface.
public void Quit()
{
    // Displays a message indicating that the employee has quit.
    Console.WriteLine("The employee has quit.");
}

}

// Creates the Program class that contains the Main() method.
class Program
{
// The Main() method is where the program begins running.
static void Main(string[] args)
{
// Creates a new Employee object.
// The firstName property is set to "Sample".
// The lastName property is set to "Student".
Employee employee = new Employee
{
firstName = "Sample",
lastName = "Student"
};

    // Calls the SayName() method on the Employee object.
    // This displays the employee's name in the console.
    employee.SayName();

    // Creates an IQuittable object using the Employee object.
    // This demonstrates polymorphism because an Employee can be treated as an IQuittable.
    IQuittable quittableEmployee = employee;

    // Calls the Quit() method through the IQuittable interface.
    // The Employee's implementation of Quit() is executed.
    quittableEmployee.Quit();

    // Keeps the console window open until the user presses Enter.
    Console.ReadLine();
}

}
