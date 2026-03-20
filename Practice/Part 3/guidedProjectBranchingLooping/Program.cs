// See https://aka.ms/new-console-template for more information
// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";


// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6]; //maxpets is the number of rows and 6 is the number of columns

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch(i)
    {
        case 0:
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
        break;
    case 1:
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
        break;
    case 2:
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
        break;
    case 3:
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
       break;
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
}

// display the top-level menu options

Console.Clear();
do 
{
Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine(" 9. Edit any animal’s information");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
    switch(menuSelection)
{
    case "1":
    for (int i = 0; i < maxPets; i++)
        {
            // if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 1] != "Species: " && ourAnimals[i, 2] != "Age: " && ourAnimals[i, 3] != "Nickname: " && ourAnimals[i, 4] != "Physical description: " && ourAnimals[i, 5] != "Personality: ")
            // {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(ourAnimals[i, j]);
                }
           
             
            //}
            Console.ReadLine(); 
            
        }
    
        break;
    case "2":
    for (int i = 0; i < maxPets; i++)
        {
            int rowCount = 0;
            if (ourAnimals[i, 0] == "ID #: " && ourAnimals[i, 1] == "Species: " && ourAnimals[i, 2] == "Age: " && ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 5] == "Personality: ")
            {
                for (int j = 0; j < 6; j++)
                {
                    
                    Console.Write(ourAnimals[i, j]);
                    string? userInput = Console.ReadLine();
                    ourAnimals[i, j] = ourAnimals[i, j] + userInput;
                    //  Console.ReadLine();
                    rowCount++;
                }
           
              //Console.ReadLine();
            }
            if (rowCount == 6)
            {
                break;
            }
            
        }
    
    readResult = Console.ReadLine();
        break;
    case "3":
    for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 2] == "Age: " )
            {
                Console.WriteLine($"Animal {ourAnimals[i, 0]} {ourAnimals[i, 3]} has incomplete age information. Please enter the age for this animal.");
                Console.Write("Enter age: ");
                string? age = Console.ReadLine();
                ourAnimals[i, 2] = ourAnimals[i, 2] + age;
              //Console.ReadLine();
            }
            if (ourAnimals[i, 4] == "Physical description: " )
            {
                Console.WriteLine($"Animal {ourAnimals[i, 0]} {ourAnimals[i, 3]} has incomplete physical description information. Please enter the physical description for this animal.");
                Console.Write("Enter physical description: ");
                string? physicalDescription = Console.ReadLine();
                ourAnimals[i, 4] = ourAnimals[i, 4] + physicalDescription;
              //Console.ReadLine();
            }
            if (ourAnimals[i, 2] != "Age: " && ourAnimals[i, 4] != "Physical description: " )
            {
                Console.WriteLine($"Animal {ourAnimals[i, 0]} {ourAnimals[i, 3]} has complete age and physical description information.");
            }
             Console.ReadLine();

            }
       break;     
    case "4":
    for (int i = 0; i < maxPets; i++)
        {
            
            if (ourAnimals[i, 3] == "Nickname: " )
            {
                Console.WriteLine($"Animal {ourAnimals[i, 0]} {ourAnimals[i, 3]} has incomplete nickname information. Please enter the nickname for this animal.");
                Console.Write("Enter nickname: ");
                string? nickname = Console.ReadLine();
                ourAnimals[i, 3] = ourAnimals[i, 3] + nickname;
              //Console.ReadLine();
            }
            if (ourAnimals[i, 5] == "Personality: " )
            {
                Console.WriteLine($"Animal {ourAnimals[i, 0]} {ourAnimals[i, 3]} has incomplete personality information. Please enter the personality for this animal.");
                Console.Write("Enter personality: ");
                string? personality = Console.ReadLine();
                ourAnimals[i, 5] = ourAnimals[i, 5] + personality;

              //Console.ReadLine();
            }
            if (ourAnimals[i, 3] != "Nickname: " && ourAnimals[i, 5] != "Personality: " )
            {
                Console.WriteLine($"Animal {ourAnimals[i, 0]} {ourAnimals[i, 3]} has complete nickname and personality information.");
            }
             Console.ReadLine();

            }
        break;
    case "5":
    for(int i = 0; i < maxPets; i++)
        {
            if(ourAnimals[i,2] != "Age: " || ourAnimals[i,2] == "Age:  ")
                    {
                        Console.WriteLine($"would you like to edit animal {ourAnimals[i,0]}    {ourAnimals[i,3]}'s age?(yes/no) ");
                        Console.WriteLine($"{ourAnimals[i,2]}");
                        string? editAge = Console.ReadLine();
                        if (editAge != null)
                        {
                            if (editAge.ToLower() == "yes")
                            {
                                Console.Write("Enter new age: ");
                                string? newAge = Console.ReadLine();
                                ourAnimals[i, 2] = "Age: " + newAge;
                            }
                            else if (editAge.ToLower() == "no")
                            {
                                    Console.WriteLine($"Animal {ourAnimals[i, 0]} {ourAnimals[i, 3]}'s age will not be edited.");
                                    Console.ReadLine();
                                    continue;
                            } 
                        }
                    }
        }
    break;
    case "6":
    for(int i = 0; i < maxPets; i++)
        {
            if(ourAnimals[i,5] != "Personality: " || ourAnimals[i,5] == "Personality:  ")
                    {
                        Console.WriteLine($"would you like to edit animal {ourAnimals[i,0]}    {ourAnimals[i,3]}'s personality?(yes/no) ");
                        Console.WriteLine($"{ourAnimals[i,5]}");
                        string? editPersonality = Console.ReadLine();
                        if (editPersonality != null)
                        {
                            if (editPersonality.ToLower() == "yes")
                            {
                                Console.Write("Enter new personality: ");
                                string? newPersonality = Console.ReadLine();
                                ourAnimals[i, 5] = "Personality: " + newPersonality;
                            }
                            else if (editPersonality.ToLower() == "no")
                            {
                                    Console.WriteLine($"Animal {ourAnimals[i, 0]} {ourAnimals[i, 3]}'s personality will not be edited.");
                                    Console.ReadLine();
                                    continue;
                            } 
                        }
                    }
        }
    break;
    case "7":
    Console.Write("Search for cats with the following characteristic in their physical description: ");
              string? searchcatCharacteristic = Console.ReadLine().ToLower();
    for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 4] != "Physical description: ")
            {
              string  arrayStorage = ourAnimals[i, 4].ToLower();
              
              if (searchcatCharacteristic != null)
                        {
                            if (arrayStorage.Contains(searchcatCharacteristic) && ourAnimals[i, 1] == "Species: cat")
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j]);
                                }
                                Console.ReadLine();
                            }
                        }
              
            }
        }
    break;
    case "8":
    Console.Write("Search for dogs with the following characteristic in their physical description: ");
    string searchdogCharacteristic = Console.ReadLine().ToLower();
    for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 4] != "Physical description: ")
            {
              string  arrayStorage = ourAnimals[i, 4].ToLower();
              
              if (searchdogCharacteristic != null)
                        {
                            if (arrayStorage.Contains(searchdogCharacteristic) && ourAnimals[i, 1] == "Species: dog")
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j]);
                                }
                                Console.ReadLine();
                            }
                        }
              
            }
        }
    break;   
    case "9":    
        Console.Write("Enter the ID # of the animal you would like to edit: ");
                string? editID = Console.ReadLine();
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 0] == "ID #: " + editID)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.WriteLine(ourAnimals[i, j]);
                            Console.Write("Enter new information : ");
                            string? userInput = Console.ReadLine();
                            ourAnimals[i, j] = ourAnimals[i, j].Split(": ")[0] + ": " + userInput;
                        }
                        Console.ReadLine();
                    }
                }  
    break;
}
}

} while (menuSelection != "exit");
// Console.WriteLine($"You selected menu option {menuSelection}.");
// Console.WriteLine("Press the Enter key to continue");

// // pause code execution
// readResult = Console.ReadLine();



