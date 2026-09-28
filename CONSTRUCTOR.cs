using System; // Imports the System namespace so we can use Console and other built-in C# features.

class Person // Creates a Person class that will contain properties and constructors.
{
// Creates a constant value that cannot be changed after it is declared.
private const string Species = "Human";

// Creates a property to store the person's name.
public string Name { get; set; }

// Creates a property to store the person's age.
public int Age { get; set; }

// Creates the first constructor with no parameters.
public Person()
    : this("Unknown", 0) // Chains this constructor to the second constructor.
{
    // This constructor calls the other constructor and provides default values.
}

// Creates the second constructor that accepts a name and an age.
public Person(string name, int age)
{
    // Stores the name passed into the constructor in the Name property.
    Name = name;

    // Stores the age passed into the constructor in the Age property.
    Age = age;
}

// Creates a method that displays the person's information.
public void DisplayInformation()
{
    // Creates a local variable using the var keyword.
    // The compiler automatically determines that message is a string.
    var message = "This variable uses var";

    // Prints the person's name.
    Console.WriteLine("Name: " + Name);

    // Prints the person's age.
    Console.WriteLine("Age: " + Age);

    // Prints the constant Species value.
    Console.WriteLine("Species: " + Species);

    // Prints the variable created using the var keyword.
    Console.WriteLine(message);
}

}

class Program // Defines the Program class that contains the Main method.
{
// The Main method is where the program begins execution.
static void Main(string[] args)
{
// Creates a Person object using the constructor that accepts a name and age.
Person person = new Person("Kaden", 22);

    // Calls the DisplayInformation method to display the object's information.
    person.DisplayInformation();

    // Pauses the console so the user can see the output before the program closes.
    Console.ReadLine();
}

}
