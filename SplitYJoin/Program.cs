//Invertiremos y combinaremos la matriz de caracteres en una nueva cadena.
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
System.Console.WriteLine(result + "\n");


//Combinación de todos los caracteres en una nueva cadena de valores separados por comas mediante Join()
string result2 = String.Join(",", valueArray);
System.Console.WriteLine(result2 + "\n");

//Split() de la nueva cadena de valores separados por comas en una matriz de cadenas
string[] items = result2.Split(',');
foreach (string item in items)
{
    System.Console.WriteLine(item);
}
