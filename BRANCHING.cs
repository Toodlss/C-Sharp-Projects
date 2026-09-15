// Prints the required welcome message.
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Asks the user to enter the package weight.
Console.WriteLine("Please enter the package weight:");

// Gets the package weight from the user and converts it to a decimal number.
decimal weight = Convert.ToDecimal(Console.ReadLine());

// Checks if the package weight is greater than 50.
if (weight > 50)
{
// Displays an error message if the package is too heavy.
Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

// Ends the program so the user is not asked for the dimensions.
return;

}

// Asks the user to enter the package width.
Console.WriteLine("Please enter the package width:");

// Gets the package width from the user and converts it to a decimal number.
decimal width = Convert.ToDecimal(Console.ReadLine());

// Asks the user to enter the package height.
Console.WriteLine("Please enter the package height:");

// Gets the package height from the user and converts it to a decimal number.
decimal height = Convert.ToDecimal(Console.ReadLine());

// Asks the user to enter the package length.
Console.WriteLine("Please enter the package length:");

// Gets the package length from the user and converts it to a decimal number.
decimal length = Convert.ToDecimal(Console.ReadLine());

// Adds the width, height, and length together to get the total dimensions.
decimal totalDimensions = width + height + length;

// Checks if the total dimensions are greater than 500.
if (totalDimensions > 500)
{
// Displays an error message if the package is too large.
Console.WriteLine("Package too big to be shipped via Package Express.");

// Ends the program because the package cannot be shipped.
return;

}

// Multiplies the height, width, and length together, then multiplies the result by the weight.
decimal quote = height * width * length * weight;

// Divides the calculated amount by 100 to get the shipping quote.
quote = quote / 100;

// Displays the shipping quote as a dollar amount with two decimal places.
Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

// Prints the final thank-you message.
Console.WriteLine("Thank you!");
