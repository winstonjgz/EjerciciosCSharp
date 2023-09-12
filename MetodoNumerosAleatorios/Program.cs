System.Console.WriteLine("Generating random numbers: ");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i =0; i<5; i++)
    {
        System.Console.WriteLine($"{random.Next(1,100)}");
    }
    System.Console.WriteLine();
}
