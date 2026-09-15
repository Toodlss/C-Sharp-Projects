// Displays the name of the school.
Console.WriteLine("The Tech Academy.");

// Displays the title of the daily report.
Console.WriteLine("Student Daily Report.");

// Asks the student for their name and stores the answer as a string.
Console.Write("What is your name? ");
string studentName = Console.ReadLine();

// Asks the student what course they are taking and stores the answer as a string.
Console.Write("What course are you on? ");
string courseName = Console.ReadLine();

// Asks the student for their page number and stores the answer as an integer.
Console.Write("What page number? ");
int pageNumber = Convert.ToInt32(Console.ReadLine());

// Asks if the student needs help and stores the answer as a Boolean (true or false).
Console.Write("Do you need help with anything? Please answer true or false. ");
bool needsHelp = Convert.ToBoolean(Console.ReadLine());

// Asks the student about their positive experiences and stores the answer as a string.
Console.Write("Were there any positive experiences you'd like to share? Please give specifics. ");
string positiveExperiences = Console.ReadLine();

// Asks the student for additional feedback and stores the answer as a string.
Console.Write("Is there any other feedback you'd like to provide? Please be specific. ");
string additionalFeedback = Console.ReadLine();

// Asks the student how many hours they studied and stores the answer as a double.
Console.Write("How many hours did you study today? ");
double studyHours = Convert.ToDouble(Console.ReadLine());

// Displays the required ending message.
Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");