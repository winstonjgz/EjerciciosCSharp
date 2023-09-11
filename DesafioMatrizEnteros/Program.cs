﻿//Desafío de combinar valores de matriz de cadenas como cadenas y enteros.

string[] values = { "12,3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if(decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

System.Console.WriteLine($"Message: {message}");
System.Console.WriteLine($"Total: {total}");

//Generar operaciones matemáticas como tipos de números específicos
int value1 = 12;
decimal value2 = 6.2m;
float value3= 4.3f;


int result1 = Convert.ToInt32((decimal)value1 / value2);
System.Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");


float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
