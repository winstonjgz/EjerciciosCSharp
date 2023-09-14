//Uso de métodos para calcular el precio total de compra
double total = 0;
double minumumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

System.Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    //double result = items[itemIndex] * (1-discounts[itemIndex]);
    //return result;
    return items[itemIndex] * (1-discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{

    return total >= minumumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0,5);
}


//Crear un método que devuelva un entero
double usd = 23.73;
int vnd = UsdToVnd(usd);

System.Console.WriteLine($"${usd} USD = ${vnd} VND");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int) (rate * usd);
}

//Crear un método que devuelva un valor doble
double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}
System.Console.WriteLine($"${vnd} VND = ${usd} USD");

System.Console.WriteLine("\n");
//Creación de un método que devuelve una cadena
string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));
string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}

//Creación de un método para invertir palabras en una oración

string input1 = "there are snakes at the zoo";

Console.WriteLine(input1);
Console.WriteLine(ReverseSentence(input1));

string ReverseSentence(string input1) 
{
    string result = "";
    string[] words = input1.Split(" ");

    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}

//Creación de un método que devuelve un valor booleano

string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}
bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}


//Encontrar monedas para dar el cambio
int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}


int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return new int[] { curr, next };
            }

        }
    }

    return new int[0];
}

//Encontrar varios pares de monedas para dar el cambio
int target2 = 80;
int[] coins2 = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result2 = TwoCoins2(coins, target2);

if (result2.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result2.GetLength(0); i++) 
    {
        if (result2[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result2[i,0]},{result2[i,1]}");
    }
}

int[,] TwoCoins2(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}

//Capturar la nueva matriz de devolución