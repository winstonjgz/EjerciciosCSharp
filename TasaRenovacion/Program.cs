Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
   Console.WriteLine("Your subscription has expired");
}
else if (daysUntilExpiration == 1)
{
    console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    console.WriteLine($"Your subscription expires in {dayUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    console.WriteLine($"Your subscription will expire soon. Renew now.");
    discountPercentage = 10;
}
if (discountPercentage > 0)
{
    console.Write($"Renew now and save {discountPercentage}%.");
}

