string[] fraudulentOrderIds = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (var orderId in fraudulentOrderIds)
{
    if (orderId.StartsWith("B"))
    {
        Console.WriteLine($"The Fraudulent is: {orderId}");
    }
}

