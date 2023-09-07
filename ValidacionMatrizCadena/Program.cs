string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;
int periodLocation = 0;

/*foreach (var myString in myStrings)
{
    periodLocation = myString.IndexOf(".");
    
    if (periodLocation < 0)
    {
        continue;
    }
    
    Console.WriteLine("" + myString.Substring(0, periodLocation), myString.Substring(periodLocation + 1));
    
}*/

string myString = "";

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
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