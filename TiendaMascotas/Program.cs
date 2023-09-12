// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";
decimal decimalDonation = 0.00m;

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

        /* case 4:
            break;

        case 5:
            break; */

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";

}

// display the top-level menu options

do
{


    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();


    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    /*Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    readResult = Console.ReadLine();*/
    switch (menuSelection)
    {
        case "1":
            //Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    //Console.WriteLine(ourAnimals[i, 0]);
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                    System.Console.WriteLine("\n");
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            //Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {


                while (anotherPet == "y" && petCount < maxPets)
                {
                    // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                    petCount = petCount + 1;

                    bool validEntry = false;
                    do
                    {
                        Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalSpecies = readResult.ToLower();
                            if (animalSpecies != "dog" && animalSpecies != "cat")
                            {
                                //Console.WriteLine($"You entered: {animalSpecies}.");
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);

                    animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                    do
                    {
                        int petAge;
                        Console.WriteLine("Enter the pet's age or enter ? if unknown");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalAge = readResult;
                            if (animalAge != "?")
                            {
                                validEntry = int.TryParse(animalAge, out petAge);
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);

                    do
                    {
                        Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalPhysicalDescription = readResult.ToLower();
                            if (animalPhysicalDescription == "")
                            {
                                animalPhysicalDescription = "tbd";
                            }
                        }
                    } while (animalPhysicalDescription == "");

                    do
                    {
                        Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalPersonalityDescription = readResult.ToLower();
                            if (animalPersonalityDescription == "")
                            {
                                animalPersonalityDescription = "tbd";
                            }
                        }
                    } while (animalPersonalityDescription == "");

                    do
                    {
                        Console.WriteLine("Enter a nickname for the pet");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalNickname = readResult.ToLower();
                            if (animalNickname == "")
                            {
                                animalNickname = "tbd";
                            }
                        }
                    } while (animalNickname == "");

                    ourAnimals[petCount, 0] = "ID #: " + animalID;
                    ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                    ourAnimals[petCount, 2] = "Age: " + animalAge;
                    ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                    ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                    ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;
                    // check maxPet limit
                    if (petCount < maxPets)
                    {
                        // another pet?
                        Console.WriteLine("Do you want to enter info for another pet (y/n)");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                anotherPet = readResult.ToLower();
                            }

                        } while (anotherPet != "y" && anotherPet != "n");
                    }
                }

                if (petCount >= maxPets)
                {
                    Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                }
            }

            break;
        case "3":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            string catCharacteristics = "";

            while (catCharacteristics == "")
            {

                Console.WriteLine($"\nEnter one or more desired dog characteristics to search for separated by comma: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    catCharacteristics = readResult.ToLower().Trim();
                    Console.WriteLine();
                }
            }

            string[] catSearches = catCharacteristics.Split(",");
            
            for (int i = 0; i < catSearches.Length; i++)
            {
                catSearches[i] = catSearches[i].Trim();
            }

            Array.Sort(catSearches);
            // #4 update to "rotating" animation with countdown
            string[] searchingIcons1 = {" |", " /", "--", " \\", " *"};

            bool matchesAnyCat = false;

            
            string catDescription = "";
            
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("cat"))
                {

                    // Search combined descriptions and report results
                    catDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                    bool matchesCurrentCat = false;

                    foreach (string term in catSearches)
                    {
                        // only search if there is a term to search for
                        if (term != null && term.Trim() != "")
                        {
                            for (int j = 2; j > -1 ; j--)
                            {
                                
                                foreach (string icon in searchingIcons1)
                                {
                                    Console.Write($"\rsearching our cat {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
                                    Thread.Sleep(100);
                                }
                                
                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                            }

                            
                            if (catDescription.Contains(" " + term.Trim() + " "))
                            {
                                
                                Console.WriteLine($"\rOur cat {ourAnimals[i, 3]} matches your search for {term.Trim()}");

                                matchesCurrentCat = true;
                                matchesAnyCat = true;
                            }
                        }
                    }
                    
                    
                    if (matchesCurrentCat)
                    {
                        Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{catDescription}\n");
                    }
                }
            }

            if (!matchesAnyCat)
            {
                Console.WriteLine("None of our cats are a match found for: " + catCharacteristics);
            }

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "8":


            string dogCharacteristics = "";

            while (dogCharacteristics == "")
            {

                Console.WriteLine($"\nEnter one or more desired dog characteristics to search for separated by comma: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristics = readResult.ToLower().Trim();
                    Console.WriteLine();
                }
            }

            string[] dogSearches = dogCharacteristics.Split(",");
            
            for (int i = 0; i < dogSearches.Length; i++)
            {
                dogSearches[i] = dogSearches[i].Trim();
            }

            Array.Sort(dogSearches);
            // #4 update to "rotating" animation with countdown
            string[] searchingIcons = {" |", " /", "--", " \\", " *"};

            bool matchesAnyDog = false;

            
            string dogDescription = "";
            
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {

                    // Search combined descriptions and report results
                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                    bool matchesCurrentDog = false;

                    foreach (string term in dogSearches)
                    {
                        // only search if there is a term to search for
                        if (term != null && term.Trim() != "")
                        {
                            for (int j = 2; j > -1 ; j--)
                            {
                                
                                foreach (string icon in searchingIcons)
                                {
                                    Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
                                    Thread.Sleep(100);
                                }
                                
                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                            }

                            // #3a iterate submitted characteristic terms and search description for each term
                            if (dogDescription.Contains(" " + term.Trim() + " "))
                            {
                                // #3b update message to reflect current search term match 

                                Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

                                matchesCurrentDog = true;
                                matchesAnyDog = true;
                            }
                        }
                    }
                    
                    // #3d if the current dog is match, display the dog's info
                    if (matchesCurrentDog)
                    {
                        Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
                    }
                }
            }

            if (!matchesAnyDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
            }

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
