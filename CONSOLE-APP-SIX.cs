using System;
using System.Collections.Generic;

// Create the main program class.
class Program
{
    // This is where the program starts.
    static void Main(string[] args)
    {
        // Create a list of strings with two identical strings.
        List<string> games = new List<string>
        {
            "Minecraft",
            "Black Ops II",
            "Black Ops III",
            "Dark Souls",
            "Cyberpunk 2077",
            "Minecraft",
            "Monster Hunter",
            "Black Ops III"
        };

        // Create a new list to keep track of strings that have already appeared.
        List<string> previousGames = new List<string>();

        // Use a foreach loop to go through each game in the games list.
        foreach (string game in games)
        {
            // Check if the current game has already appeared in the list.
            if (previousGames.Contains(game))
            {
                // Display a message saying that the game is a duplicate.
                Console.WriteLine(game + " - this item is a duplicate");
            }
            else
            {
                // Display a message saying that the game is unique.
                Console.WriteLine(game + " - this item is unique");

                // Add the game to the previousGames list so it can be checked later.
                previousGames.Add(game);
            }
        }

        // Keep the console window open so the user can see the results.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}