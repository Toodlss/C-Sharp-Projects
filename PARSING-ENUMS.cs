using System; // Imports the System namespace so we can use Console methods and Enum methods.

// Creates an enum named DaysOfTheWeek.
// An enum is a special data type that contains a set of named values.
enum DaysOfTheWeek
{
// Creates the seven possible values for the days of the week.
Monday,
Tuesday,
Wednesday,
Thursday,
Friday,
Saturday,
Sunday
}

// Creates the Program class that contains the Main() method.
class Program
{
// The Main() method is where the program begins running.
static void Main(string[] args)
{
// Starts a try block.
// Code inside this block will be monitored for errors.
try
{
// Asks the user to enter the current day of the week.
Console.WriteLine("Please enter the current day of the week:");

        // Reads the user's input from the console and stores it in a string variable.
        string input = Console.ReadLine();

        // Converts the user's input into the DaysOfTheWeek enum data type.
        // Parse ignores capitalization, so "monday" and "Monday" will both work.
        DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(
            typeof(DaysOfTheWeek),
            input,
            true
        );

        // Displays the day that was entered after it has been converted to the enum type.
        Console.WriteLine("The current day is: " + currentDay);
    }

    // Catches an error if the user enters something that is not a valid day.
    catch (Exception)
    {
        // Displays the required error message when invalid input is entered.
        Console.WriteLine("Please enter an actual day of the week.");
    }

    // Keeps the console window open until the user presses Enter.
    Console.ReadLine();
}

}
