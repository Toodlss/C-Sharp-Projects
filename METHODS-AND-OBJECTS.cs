using System;

// Create a Person class that will contain information shared by people.
class Person
{
// Create a string property to store the person's first name.
public string FirstName { get; set; }

// Create a string property to store the person's last name.
public string LastName { get; set; }

// Create a void method that displays the person's full name.
public void SayName()
{
    // Write the person's first and last name to the console.
    Console.WriteLine("Name: " + FirstName + " " + LastName);
}

}

// Create an Employee class that inherits all of the properties and methods from Person.
class Employee : Person
{
// Create an integer property to store the employee's ID number.
public int Id { get; set; }
}

// Create the Program class that contains the Main method.
class Program
{
// The Main method is where the program starts running.
static void Main(string[] args)
{
// Create and initialize a new Employee object.
Employee employee = new Employee();

    // Set the employee's first name to "Sample".
    employee.FirstName = "Kaden";

    // Set the employee's last name to "Student".
    employee.LastName = "Bilyeu";

    // Set the employee's ID number.
    employee.Id = 1;

    // Call the SayName method inherited from the Person class.
    employee.SayName();
}

}
