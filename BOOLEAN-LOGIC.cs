// Asks the user to enter their age.
Console.WriteLine("What is your age?");

// Gets the user's age and converts the input into an integer.
int age = Convert.ToInt32(Console.ReadLine());

// Asks the user whether they have ever had a DUI.
Console.WriteLine("Have you ever had a DUI?");

// Gets the user's answer and converts it into a Boolean value (true or false).
bool hasDUI = Convert.ToBoolean(Console.ReadLine());

// Asks the user how many speeding tickets they have.
Console.WriteLine("How many speeding tickets do you have?");

// Gets the number of speeding tickets and converts the input into an integer.
int speedingTickets = Convert.ToInt32(Console.ReadLine());

// Checks all of the insurance requirements:
// The applicant must be over 15 years old.
// The applicant must not have a DUI.
// The applicant must have 3 or fewer speeding tickets.
bool qualified = age > 15 && !hasDUI && speedingTickets <= 3;

// Prints the qualification result to the screen.
Console.WriteLine("Qualified?");

// Displays true if the applicant meets all requirements, or false if they do not.
Console.WriteLine(qualified);
