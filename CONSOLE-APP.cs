// sets the initial value of number to 500 and number2 to 85
int number = 500;
int number2 = 85;
// uses a do-while loop to subtract number2 from number until number is less than or equal to 0
do
{
    number -= number2;
    Console.WriteLine("Current value of number: " + number);
} while (number > 0);