using System;

// Creates a class named MathOperations.
class MathOperations
{
// Creates a void method named Calculate.
// The method takes two integer parameters: number1 and number2.
// Because the method is void, it does not return a value.
public void Calculate(int number1, int number2)
{
// Performs a math operation on the first integer.
// This example multiplies the first integer by 10.
number1 = number1 * 10;

    // Displays the result of the math operation on the first integer.
    Console.WriteLine("The first number multiplied by 10 is: " + number1);

    // Displays the second integer to the screen.
    Console.WriteLine("The second number is: " + number2);
}

}

// Creates the main program class.
class Program
{
// The Main method is where the console application starts running.
static void Main(string[] args)
{
// Creates an instance of the MathOperations class.
// This allows us to use the Calculate method from that class.
MathOperations math = new MathOperations();

    // Calls the Calculate method and passes in two numbers.
    // The first number is 5 and the second number is 20.
    math.Calculate(5, 20);

    // Calls the Calculate method again.
    // This time, the parameters are specified by name.
    // number1 receives 10 and number2 receives 30.
    math.Calculate(number1: 10, number2: 30);

    // Keeps the console window open so the user can see the results.
    Console.ReadLine();
}

}
