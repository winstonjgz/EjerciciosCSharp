string permission = "Administrator|Manager|User";
string permissionLower = permission.ToLower();
string readResult;
string validEntrance;

Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");
do
{
    readResult = Console.ReadLine();
    validEntrance = readResult.Trim();
    validEntrance = validEntrance.ToLower();
    /*Console.WriteLine("Los permisos son: "+permissionLower);
    Console.WriteLine("La entrada es: "+validEntrance);
    Console.WriteLine("La verificacion de entrada es: "+permissionLower.Contains(validEntrance));*/

    if (permissionLower.Contains(validEntrance))
    {
        if (validEntrance == "administrator" || validEntrance == "manager" || validEntrance == "user")
        {
            Console.WriteLine($"Your input value ({readResult}) has been accepted.");
        }else{
            Console.WriteLine($"The role name that you entered, ({readResult}) is not valid. Enter your role name (Administrator, Manager, or User)");
        }
        
    }
    else
    {
        Console.WriteLine($"The role name that you entered, ({readResult}) is not valid. Enter your role name (Administrator, Manager, or User)");
    } 
    
} while (!(validEntrance == "administrator" || validEntrance == "manager" || validEntrance == "user"));
