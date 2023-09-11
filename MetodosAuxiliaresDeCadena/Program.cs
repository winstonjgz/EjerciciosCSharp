string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
openingPosition += 1;
Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

//Ejercicio 2
string message1 = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition1 = message1.IndexOf(openSpan);
int closingPosition1 = message1.IndexOf(closeSpan);

openingPosition1 += openSpan.Length;
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message1.Substring(openingPosition1, length1));

//Recuperar la última aparición de una subcadena
string message2 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition2 = message2.LastIndexOf('(');

openingPosition2 += 1;
int closingPosition2 = message2.LastIndexOf(')');
int length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, length2)+"\n");


//Recuperar todas las instancias de subcadenas entre paréntesis
string message3 = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition3 = message3.IndexOf('(');
    if (openingPosition3 == -1) break;

    openingPosition3 += 1;
    int closingPosition3 = message3.IndexOf(')');
    int length3 = closingPosition3 - openingPosition3;
    Console.WriteLine(message3.Substring(openingPosition3, length3));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message3 = message3.Substring(closingPosition3 + 1);
}

System.Console.WriteLine("\n");

//Trabajar con diferentes tipos de conjuntos de símbolos
string message4 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
//string message4 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message4}");
char[] openSymbols4 = { '[', '{', '(' };


/*int startPosition4 = 6;
int openingPosition4 = message4.IndexOfAny(openSymbols4);
Console.WriteLine($"Found WITHOUT using startPosition: {message4.Substring(openingPosition4)}");

openingPosition4 = message4.IndexOfAny(openSymbols4, startPosition4);
Console.WriteLine($"Found WITH using startPosition: {message4.Substring(openingPosition4)}"+"\n");*/

int closingPosition4 = 0;

while (true)
{
    int openingPosition4 = message4.IndexOfAny(openSymbols4, closingPosition4);

    if (openingPosition4 == -1) break;

    string currentSymbol4 = message4.Substring(openingPosition4, 1);

    // Now  find the matching closing symbol
    char matchingSymbol4 = ' ';

    switch (currentSymbol4)
    {
        case "[":
            matchingSymbol4 = ']';
            break;
        case "{":
            matchingSymbol4 = '}';
            break;
        case "(":
            matchingSymbol4 = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition4 += 1;
    closingPosition4 = message4.IndexOf(matchingSymbol4, openingPosition4);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length4 = closingPosition4 - openingPosition4;
    Console.WriteLine(message4.Substring(openingPosition4, length4));
}