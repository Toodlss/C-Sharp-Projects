using System;

// Creates a class named MathOperations.
class MathOperations
{
// Creates a void method that takes an integer as a parameter.
// The method divides the integer by 2 and displays the result.
public void DivideByTwo(int number)
{
// Divides the number entered by the user by 2.
int result = number / 2;

    // Displays the result to the screen.
    Console.WriteLine("Your number divided by 2 is: " + result);
}

// Creates a method with an output parameter.
// The "out" keyword means the method will send a value back through the parameter.
public void GetResults(int number, out int result)
{
    // Divides the number by 2 and stores the result in the output parameter.
    result = number / 2;
}

// Creates an overloaded version of the DivideByTwo method.
// This version takes two integers instead of one.
public void DivideByTwo(int number1, int number2)
{
    // Adds the two numbers together before dividing the total by 2.
    int result = (number1 + number2) / 2;

    // Displays the result to the screen.
    Console.WriteLine("The two numbers added together and divided by 2 are: " + result);
}

}

// Creates a static class.
static class StaticExample
{
// Creates a static method that can be called without creating an object of this class.
public static void DisplayMessage()
{
// Displays a message explaining that the static method was called.
Console.WriteLine("This message came from a static class.");
}
}

// Creates the main Program class.
class Program
{
// The Main method is where the console application starts.
static void Main(string[] args)
{
// Creates an instance of the MathOperations class.
MathOperations math = new MathOperations();

    // Asks the user to enter a number.
    Console.WriteLine("Please enter a number:");

    // Reads the user's input from the keyboard and converts it from a string to an integer.
    int userNumber = Convert.ToInt32(Console.ReadLine());

    // Calls the DivideByTwo method and passes the user's number to it.
    math.DivideByTwo(userNumber);

    // Creates an integer variable that will receive the output parameter.
    int outputResult;

    // Calls the GetResults method.
    // The "out" keyword allows the method to send the calculated result back to outputResult.
    math.GetResults(userNumber, out outputResult);

    // Displays the value received from the output parameter.
    Console.WriteLine("The output parameter result is: " + outputResult);

    // Calls the overloaded DivideByTwo method.
    // This version accepts two integers instead of one.
    math.DivideByTwo(10, 20);

    // Calls the static method from the StaticExample class.
    // No object needs to be created because the class is static.
    StaticExample.DisplayMessage();

    // Keeps the console window open until the user presses Enter.
    Console.ReadLine();
}

}
