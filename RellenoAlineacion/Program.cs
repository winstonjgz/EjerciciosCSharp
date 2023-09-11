string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

//Aplicación de formato a cadenas mediante la adición de espacio en blanco antes o después
string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));
 Console.WriteLine(input.PadRight(12));
 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));

 //Uso de cadenas con relleno
string paymentId = "769C";
var formattedLine = paymentId.PadRight(6);
System.Console.WriteLine(formattedLine);

//Adición del nombre del beneficiario a la salida
string payeeName = "Mr. Stephen Ortega";
formattedLine += payeeName.PadRight(24);
System.Console.WriteLine(formattedLine);

//Adición del importe del pago a la salida
string paymentAmount = "$5,000.00";
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890");
System.Console.WriteLine(formattedLine);