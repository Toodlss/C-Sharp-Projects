// Creates a class named MathOperations.
class MathOperations
{
    // Creates the first method named MathOperation.
    // This method accepts an integer and returns an integer.
    public int MathOperation(int number)
    {
        // Adds 10 to the integer that was passed into the method.
        int result = number + 10;

        // Returns the result back to the Main() method.
        return result;
    }

    // Creates a second method with the same name.
    // This is called method overloading because it accepts a different data type.
    // This method accepts a decimal and returns an integer.
    public int MathOperation(decimal number)
    {
        // Multiplies the decimal by 2.
        decimal result = number * 2;

        // Converts the decimal result to an integer and returns it.
        return Convert.ToInt32(result);
    }

    // Creates a third method with the same name.
    // This version accepts a string and returns an integer.
    public int MathOperation(string number)
    {
        // Creates an integer variable to store the converted string.
        int convertedNumber;

        // Attempts to convert the string into an integer.
        // If the conversion is successful, the converted number is stored in convertedNumber.
        if (int.TryParse(number, out convertedNumber))
        {
            // Subtracts 5 from the converted integer.
            int result = convertedNumber - 5;

            // Returns the result.
            return result;
        }

        // Returns 0 if the string could not be converted into an integer.
        return 0;
    }
}

// Creates the main class that contains the Main() method.
class Program
{
    // The Main() method is where the console application starts.
    static void Main(string[] args)
    {
        // Creates an instance of the MathOperations class.
        MathOperations math = new MathOperations();

        // Calls the first MathOperation method and passes in an integer.
        int integerResult = math.MathOperation(10);

        // Displays the result of the integer operation to the console.
        Console.WriteLine("Integer result: " + integerResult);

        // Calls the second MathOperation method and passes in a decimal.
        int decimalResult = math.MathOperation(10.5m);

        // Displays the result of the decimal operation to the console.
        Console.WriteLine("Decimal result: " + decimalResult);

        // Calls the third MathOperation method and passes in a string.
        // The string "20" represents an integer.
        int stringResult = math.MathOperation("20");

        // Displays the result of the string operation to the console.
        Console.WriteLine("String result: " + stringResult);
    }
}
