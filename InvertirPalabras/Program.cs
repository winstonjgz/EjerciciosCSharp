string pangram = "The quick brown fox jumps over the lazy dog";

string[] items = pangram.Split(' ');

string result = "";

foreach (string item in items)
{
    //System.Console.WriteLine(item);
    char[] valueArray = item.ToCharArray();
    Array.Reverse(valueArray);
    result += new string(valueArray)+" ";
    //System.Console.WriteLine(result);
}

System.Console.WriteLine(result);
