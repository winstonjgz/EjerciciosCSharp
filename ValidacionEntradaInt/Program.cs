int numericValue = 0;
bool validNumber = false;
string? readResult;
Console.WriteLine("Enter an integer value between 5 and 10: ");
do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    /*Console.WriteLine("El dato entrado es: "+ numericValue);
    Console.WriteLine("La validacion es: "+ validNumber);*/

    if (validNumber == false)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
    else if (validNumber == true && (numericValue<5 || numericValue >10))
    {
        Console.WriteLine($"You entered {readResult}. Please enter a number between 5 and 10.");
    } else if (validNumber == true && (numericValue >= 5 || numericValue <=10 ))
    {
        Console.WriteLine($"Your input value ({readResult}) has been accepted.");
        //break;
    }
} while (validNumber == false || (numericValue<5 || numericValue >10));

