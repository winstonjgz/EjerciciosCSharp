int monsterHealth = 10;
int heroeHealth = 10;

Random randomHit = new Random();


do
{
    

    int golpeHitHeroe = randomHit.Next(0, 10);
    Console.WriteLine($"Ataca el Heroe con {golpeHitHeroe} golpes");
    monsterHealth = monsterHealth - golpeHitHeroe;
    Console.WriteLine($"Monster was damaged and lost {golpeHitHeroe} health and now has {monsterHealth} health.");
    if (monsterHealth < 0)
    {
        Console.WriteLine("Heroe Wins!");
        break;
    }

    int golpeHitMonster = randomHit.Next(0, 10);
    Console.WriteLine($"Ataca el Monstruo con {golpeHitMonster} golpes");
    heroeHealth = heroeHealth - golpeHitMonster;
    Console.WriteLine($"Heroe was damaged and lost {golpeHitMonster} health and now has {heroeHealth} health.");
    if (heroeHealth < 0)
    {
        Console.WriteLine("Monster wins!");
        break;
    }

    
} while (monsterHealth>0 || heroeHealth >0);
