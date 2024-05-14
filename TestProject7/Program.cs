/*
    1st example will ask user to enter integer between 5 and 10.
    2nd example will ask select a role
    3rd example
*/
/*
// 1st Example
Console.WriteLine("Enter an integer value between 5 and 10");
bool isValid = false;
int number = 0;
do
{
    isValid = int.TryParse(Console.ReadLine(), out number);

    if (isValid)
    {
        if ((number <= 5) || (number >= 10))
        {
            Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10");
            isValid = false;
        }
    }
    else
        Console.WriteLine("Sorry, you entered an invalid number, please try again");

} while (!isValid);

Console.WriteLine($"Your input value ({number}) has been accepted.");
 */

/* 
// 2nd Example
string? readInput;
bool isValid = false;
Console.WriteLine("do While");
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    readInput = Console.ReadLine()?.Trim();
    readInput?.ToLower();
    if ((readInput == "administrator") || (readInput == "manager") || (readInput == "user"))
    {
        isValid = true;  
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{readInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (!isValid);

Console.WriteLine($"Your input value ({readInput}) has been accepted.");
 */

// 3rd Example
using System.ComponentModel.DataAnnotations;

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}