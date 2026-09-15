// Asks the user for a number and stores it as a long.
// The long data type allows the program to accept numbers larger than 10,000,000.
Console.Write("Enter a number to multiply by 50: ");
long number1 = Convert.ToInt64(Console.ReadLine());

// Multiplies the number by 50 and displays the result.
long result1 = number1 * 50;
Console.WriteLine("Result: " + result1);


// Asks the user for another number.
Console.Write("Enter a number to add 25 to: ");
long number2 = Convert.ToInt64(Console.ReadLine());

// Adds 25 to the number and displays the result.
long result2 = number2 + 25;
Console.WriteLine("Result: " + result2);


// Asks the user for another number.
Console.Write("Enter a number to divide by 12.5: ");
double number3 = Convert.ToDouble(Console.ReadLine());

// Divides the number by 12.5 and displays the result.
double result3 = number3 / 12.5;
Console.WriteLine("Result: " + result3);


// Asks the user for another number.
Console.Write("Enter a number to check if it is greater than 50: ");
long number4 = Convert.ToInt64(Console.ReadLine());

// Checks whether the number is greater than 50 and displays true or false.
bool result4 = number4 > 50;
Console.WriteLine("Is the number greater than 50? " + result4);


// Asks the user for another number.
Console.Write("Enter a number to divide by 7: ");
long number5 = Convert.ToInt64(Console.ReadLine());

// Uses the % operator to find the remainder after dividing by 7.
long result5 = number5 % 7;
Console.WriteLine("The remainder is: " + result5);