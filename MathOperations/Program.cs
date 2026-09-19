// Imports the System namespace so we can use Console and other basic C# functionality.
using System;

// Defines the main Program class for the console application.
class Program
{
    // The Main method is where the program starts running.
    static void Main(string[] args)
    {
        // Asks the user what number they want to perform the math operations on.
        Console.WriteLine("What number would you like to perform the math operations on?");

        // Reads the user's input from the console and converts it from text into an integer.
        int userNumber = Convert.ToInt32(Console.ReadLine());

        // Creates an instance of the MathOperations class so we can use its methods.
        MathOperations math = new MathOperations();

        // Calls the AddTen method and passes the user's number into it.
        int additionResult = math.AddTen(userNumber);

        // Displays the result returned by the AddTen method.
        Console.WriteLine("Adding 10: " + additionResult);

        // Calls the MultiplyByTwo method and passes the user's original number into it.
        int multiplicationResult = math.MultiplyByTwo(userNumber);

        // Displays the result returned by the MultiplyByTwo method.
        Console.WriteLine("Multiplying by 2: " + multiplicationResult);

        // Calls the SubtractFive method and passes the user's original number into it.
        int subtractionResult = math.SubtractFive(userNumber);

        // Displays the result returned by the SubtractFive method.
        Console.WriteLine("Subtracting 5: " + subtractionResult);

        // Keeps the console window open until the user presses a key.
        Console.ReadKey();
    }
}