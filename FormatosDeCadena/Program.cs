string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

string first1 = "Hello";
string second1 = "World";
Console.WriteLine("{1} {0}!", first1, second1);
Console.WriteLine("{0} {0} {0}!", first1, second1);

//Aplicación de formato a valores de moneda
decimal price = 123.45m;
int discount = 50;
System.Console.WriteLine($"Price: {price:C} (Save {discount:C})");


//Formato a numeros
decimal measurement = 13456.78912m;
System.Console.WriteLine($"Measurement: {measurement:N} units");

//Formato a porcentajes
decimal tax = .36785m;
System.Console.WriteLine($"Tax rate: {tax:P2}");

//Combinación de enfoques de formato
decimal price1 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price1 - salePrice), price1);

yourDiscount += $"A discount of {((price1 - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);

//Interpolacion de cadenas
int invoiceNumber = 1204;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

System.Console.WriteLine($"Invoice Number: {invoiceNumber}");
System.Console.WriteLine($"   Shares: \t\t {productShares:N3} Product");
System.Console.WriteLine($"   Subtotal: \t\t{subtotal:C}");
System.Console.WriteLine($"   Tax: \t\t {taxPercentage:P2}");
System.Console.WriteLine($"   Total Billed:\t {total:C}");

