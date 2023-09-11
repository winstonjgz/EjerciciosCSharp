string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "Dear Ms. Barros, \n As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return. \n\nCurrently, you own 2,975,000.00 shares at a return of 12.75 %.\n\nOur new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00. \n\nHere's a quick comparison:\n\nMagic Yield         12.75 %   $55,000,000.00\nGlorious Future     13.13 %   $63,000,000.00"+"\n";

// Your logic here

Console.WriteLine(comparisonMessage);
Console.WriteLine($"Dear {customerName}, \n As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return. \n\nCurrently, you own {currentShares:C} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}. \n\nHere's a quick comparison:\n\n{currentProduct}         {currentReturn:P2}   {currentProfit:C}\n{newProduct}     {newReturn:P2}   {newProfit:C}");



//Solucion
/*string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);*/