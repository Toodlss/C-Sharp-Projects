using System; // Imports the System namespace so we can use DateTime, Console, and other basic C# features.

class Program // Defines the Program class that contains the application.
{
static void Main(string[] args) // The Main method is where the program starts running.
{
// Gets the current date and time from the computer.
DateTime currentTime = DateTime.Now;

    // Prints the current date and time to the console.
    Console.WriteLine("The current date and time is: " + currentTime);

    // Asks the user to enter the number of hours they want to add.
    Console.Write("Enter a number of hours: ");

    // Reads the user's input and converts it from a string into an integer.
    int hours = Convert.ToInt32(Console.ReadLine());

    // Adds the number of hours entered by the user to the current date and time.
    DateTime futureTime = currentTime.AddHours(hours);

    // Prints the resulting date and time to the console.
    Console.WriteLine("The date and time in " + hours + " hours will be: " + futureTime);

    // Pauses the program so the user can see the results before the console closes.
    Console.ReadLine();
}

}
