Random numero = new Random();
int lanza = numero.Next(0,2);
Console.WriteLine(lanza);

string caraocruz = lanza >= 0 ? "heads" : "tails";
Console.WriteLine($"El resultado es: {caraocruz}");
