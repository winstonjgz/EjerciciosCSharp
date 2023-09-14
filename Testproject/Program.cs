/* int firstValue = 500;
int secondvalue = 600;
int largeValue;

largeValue = System.Math.Max(firstValue, secondvalue);

Console.WriteLine(largeValue); */

/*Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 16){
    Console.WriteLine("You Win a new Car!");
} else if (total >= 10){
    Console.WriteLine("You win a new laptop");
} else if (total ==7){
    Console.WriteLine("You win a trip for two");
}
else{
    Console.WriteLine("Sorry, you lose.");
}


*/

System.Console.WriteLine(5/2);

int[] numbers = {1,2,3,4,5};
foreach (int num in numbers)
{
    System.Console.WriteLine(num);    
}

int x = 10;
int y = 3;

int result = x%y;
System.Console.WriteLine(result);

int x1= 5;
double y1;
y1= (double)(x1);
System.Console.WriteLine(y1+"\n");

int i1=0;
do{
    System.Console.WriteLine(i1);
    i1++;
} while (i1<5);

System.Console.WriteLine(Math.Sqrt(16));

System.Console.WriteLine(string.Concat(numbers));

string numbers1 = string.Concat(numbers);

System.Console.WriteLine(int.Parse(numbers1));

System.Console.WriteLine(!(true&&false));

System.Console.WriteLine(numbers1.ToString());
System.Console.WriteLine(numbers1.ToString("0.##"));