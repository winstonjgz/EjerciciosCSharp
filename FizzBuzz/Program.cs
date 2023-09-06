
string FizzBuzz = "";

for (int evalNum = 1; evalNum < 101; evalNum++) 
{
    if (evalNum%3==0 && evalNum%5==0 ){
        FizzBuzz = "FizzBuzz";
    } else if (evalNum%3==0)
    {
        FizzBuzz = "Fizz";
    } else if (evalNum%5==0)
    {
        FizzBuzz = "Buzz";
    }
    else 
    {
        FizzBuzz = "";
    }
    Console.WriteLine($"{evalNum} - {FizzBuzz}");
}
