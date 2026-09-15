using System;
using System.Collections.Generic;

// Create the main program class.
class Program
{
    // This is where the program starts.
    static void Main(string[] args)
    {
        // Create a list of integers that will be divided.
        List<int> numbers = new List<int>
        {
            10,
            20,
            30,
            40,
            50
        };

        // Start a try block so the program can catch errors that may occur.
        try
        {
            // Ask the user to enter a number to divide each number in the list by.
            Console.WriteLine("Enter a number to divide each number in the list by:");

            // Convert the user's input from a string into an integer.
            int divisor = Convert.ToInt32(Console.ReadLine());

            // Use a foreach loop to go through each number in the list.
            foreach (int number in numbers)
            {
                // Divide the current number by the number entered by the user.
                int result = number / divisor;

                // Display the result of the division to the screen.
                Console.WriteLine(number + " divided by " + divisor + " = " + result);
            }
        }
        // Catch a DivideByZeroException if the user enters zero.
        catch (DivideByZeroException)
        {
            // Display an error message explaining that a number cannot be divided by zero.
            Console.WriteLine("Error: You cannot divide a number by zero.");
        }
        // Catch a FormatException if the user enters something that is not a valid number.
        catch (FormatException)
        {
            // Display an error message explaining that the input must be a number.
            Console.WriteLine("Error: You must enter a valid number.");
        }

        // This message is outside the try/catch block, so it will execute after the error is handled.
        Console.WriteLine("The program has continued after the try/catch block.");

        // Keep the console window open so the user can see the results.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}