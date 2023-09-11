int first = 2;
string second = "4";
string result = first + second;

System.Console.WriteLine(result);

//Conversion
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

//Coercion
System.Console.WriteLine("Coercion");
decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}\n");

int myInt2 = (int)myDecimal2;
Console.WriteLine($"int: {myInt2}");


//conversión es "de ampliación" o "de restricción"
System.Console.WriteLine("conversión es de ampliación de restricción");
decimal myDecimal3 = 1.23456789m;
float myFloat = (float)myDecimal3;

Console.WriteLine($"Decimal: {myDecimal3}");
Console.WriteLine($"Float  : {myFloat}\n");


//Conversion de datos
int first4 = 5;
int second4 = 7;
string message = first4.ToString() + second4.ToString();
System.Console.WriteLine(message + "\n");

//Conversión de un objeto string en int mediante el método Parse() auxiliar
string first5 = "5";
string second5 = "7";
int sum = int.Parse(first5) + int.Parse(second5);
Console.WriteLine(sum);


//Conversión de un objeto string en int mediante la clase Convert
string value1 = "5";
string value2 = "7";
int result4 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result4 + "\n");

//Comparación de la coerción y conversión de un objeto decimal en int
int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4 + "\n");

//Conversión de una cadena en un entero con TryParse()
string value5="102";
int result5 = 0;
if (int.TryParse(value5, out result5))
{
    System.Console.WriteLine($"Measurement: {result5} "+"\n");
}
else
{
    System.Console.WriteLine("Unable to report the measurement."+"\n");
}

//Uso posterior del valor int analizado en el código
string value6 = "102";
int result6 = 0;
if (int.TryParse(value6, out result6))
{
    System.Console.WriteLine($"Measurement: {result6}" +"\n");
}
else
{
    System.Console.WriteLine("Unable to report the measurement.");
}

System.Console.WriteLine($"Measurement (w/ offset): {50 + result6}" +"\n");

//Modificación de la variable de cadena a un valor que no se pueda analizar
string value7 = "bad";
int result7 = 0;
if (int.TryParse(value7, out result7))
{
    Console.WriteLine($"Measurement: {result7}"+ "\n");
}
else
{
    Console.WriteLine("Unable to report the measurement."+ "\n");
}

if (result7 > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result7}"+ "\n");