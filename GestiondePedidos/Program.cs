string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

//System.Console.WriteLine("Sorted...");
string[] items = orderStream.Split(',');
foreach (string item in items)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("Sorted...");
Array.Sort(items);
foreach (var item in items)
{
    if (item.Length < 4 || item.Length > 4)
    {
        System.Console.WriteLine($"{item} \t - Error"); ;
    }
    else
    {

        System.Console.WriteLine($"{item}");
    }
}
