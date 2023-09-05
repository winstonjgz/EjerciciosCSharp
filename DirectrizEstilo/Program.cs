string str = "The quick brown fox jumps over the lazy dog.";
//conver the message into a char array
char[] charmessage = str.ToCharArray();
//Reverse the chars
Array.Reverse(charmessage);
int x=0;
// count the o's
foreach (char i in charmessage){
    if (i == 'o')
    {
        x++;
    }
}
//convert it back to a string
string new_message = new string(charmessage);
//print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
