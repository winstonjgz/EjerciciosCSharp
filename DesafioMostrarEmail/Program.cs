string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

//System.Console.WriteLine(corporate[1,1].ToLower());
string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};


string externalDomain = "hayworth.com";
string corporateDomain = "contoso.com";

CorporateDomainEmail();
ExternalDomainEmail();


void CorporateDomainEmail()
{
    for (int i = 0; i < corporate.GetLength(0); i++)
    {
        // display internal email addresses
        System.Console.WriteLine(corporate[i, 0].ToLower().Substring(0, 2) + corporate[i, 1].ToLower() + "@" + corporateDomain);
    }
}

void ExternalDomainEmail()
{
    for (int i = 0; i < external.GetLength(0); i++)
    {
        System.Console.WriteLine(external[i, 0].ToLower().Substring(0, 2) + external[i, 1].ToLower() + "@" + externalDomain);
    }
}


//Solucion Microsoft Learn
/*
for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com") 
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}
*/