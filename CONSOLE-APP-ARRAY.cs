using System;
using System.Collections.Generic;

// Create the main program class.
class Program
{
// This is where the program starts.
static void Main(string[] args)
{
// Create a one-dimensional array of strings.
string[] names = { "Kaden", "John", "Sarah", "Mike" };

    // Ask the user which index they want to view.
    Console.WriteLine("Select an index from the string array (0-3):");
    int stringIndex = Convert.ToInt32(Console.ReadLine());

    // Check if the index exists in the string array.
    if (stringIndex >= 0 && stringIndex < names.Length)
    {
        // Display the string stored at the selected index.
        Console.WriteLine("The string at that index is: " + names[stringIndex]);
    }
    else
    {
        // Display an error message if the index does not exist.
        Console.WriteLine("That index does not exist.");
    }

    // Create a one-dimensional array of integers.
    int[] numbers = { 10, 20, 30, 40 };

    // Ask the user which index they want to view.
    Console.WriteLine("Select an index from the integer array (0-3):");
    int integerIndex = Convert.ToInt32(Console.ReadLine());

    // Check if the index exists in the integer array.
    if (integerIndex >= 0 && integerIndex < numbers.Length)
    {
        // Display the integer stored at the selected index.
        Console.WriteLine("The integer at that index is: " + numbers[integerIndex]);
    }
    else
    {
        // Display an error message if the index does not exist.
        Console.WriteLine("That index does not exist.");
    }

    // Create a list of strings.
    List<string> games = new List<string>
    {
        "Minecraft",
        "Dark Souls",
        "Cyberpunk 2077",
        "Monster Hunter"
    };

    // Ask the user which index they want to view.
    Console.WriteLine("Select an index from the string list (0-3):");
    int listIndex = Convert.ToInt32(Console.ReadLine());

    // Check if the index exists in the list.
    if (listIndex >= 0 && listIndex < games.Count)
    {
        // Display the string stored at the selected index.
        Console.WriteLine("The string at that index is: " + games[listIndex]);
    }
    else
    {
        // Display an error message if the index does not exist.
        Console.WriteLine("That index does not exist.");
    }

    // Keep the console window open so the user can see the results.
    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
}

}
