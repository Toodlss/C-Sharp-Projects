using System;

// Creates a class that contains the math method.
class MathOperations
{
// Creates a method that accepts two integers.
// The second integer is optional because it has a default value of 0.
public int AddNumbers(int number1, int number2 = 0)
{
// Adds the two numbers together and stores the result.
int result = number1 + number2;

    // Returns the result to the code that called the method.
    return result;
}

}

// Creates the Program class that contains the Main method.
class Program
{
// The Main method is where the console application starts.
static void Main(string[] args)
{
// Creates an instance of the MathOperations class.
MathOperations math = new MathOperations();

    // Asks the user to enter the first number.
    Console.WriteLine("Enter the first number:");

    // Reads the user's input and converts it from a string to an integer.
    int number1 = Convert.ToInt32(Console.ReadLine());

    // Asks the user to enter the second number.
    // Tells the user that they can leave it blank.
    Console.WriteLine("Enter the second number (or leave it blank):");

    // Reads the user's second input as a string.
    string secondInput = Console.ReadLine();

    // Checks whether the user entered anything for the second number.
    if (string.IsNullOrWhiteSpace(secondInput))
    {
        // Calls the method with only the first number.
        // The optional second parameter automatically uses 0.
        int result = math.AddNumbers(number1);

        // Displays the result when only one number was entered.
        Console.WriteLine("The result is: " + result);
    }
    else
    {
        // Converts the second input from a string into an integer.
        int number2 = Convert.ToInt32(secondInput);

        // Calls the method with both numbers.
        int result = math.AddNumbers(number1, number2);

        // Displays the result when both numbers were entered.
        Console.WriteLine("The result is: " + result);
    }

    // Keeps the console window open so the user can see the result.
    Console.ReadLine();
}

}
