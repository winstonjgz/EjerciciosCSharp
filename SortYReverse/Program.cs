//Orden de los pallets

string[] pallets = {"B14", "A11", "B12", "A13"};

System.Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}"+"\n");
}

//Inversion de orden de los pallets
System.Console.WriteLine("");
System.Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}"+"\n");
}

//Usar métodos de matriz para borrar y cambiar de tamaño una matriz
System.Console.WriteLine("");
Array.Clear(pallets, 0, 2);
System.Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}"+"\n");
}

//Cambio de tamaño de la matriz para agregar más elementos
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}"+"\n");
}

//Cambio de tamaño de la matriz para quitar elementos
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}" + "\n");
}