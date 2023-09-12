string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
bool validLength = false;
bool validZeroes = false;
bool validRange = false;
string[] address;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if(validLength && validZeroes && validRange)
    {
        System.Console.WriteLine($"{ip} is a valid PIv4 address");
    }
    else{
        System.Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}


void ValidateLength() 
{
    
    validLength = address.Length == 4;
}
void ValidateZeroes() 
{
    
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }
    validZeroes = true;
}

void ValidateRange()
{
    
    foreach (string number in address) 
    {
        if (int.Parse(number) > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}