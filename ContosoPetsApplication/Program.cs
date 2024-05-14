
// array ourAnimals will store the following
using System.Collections;

string animalID = "";
string animalSpecies = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variable that support data entry
int maxPets = 5;
int petAge;
int petCount = 0;
string? readResult;
string menuSelection = "";
string selectedPet = "";
string specifiedCharacteristic = "";

bool validEntry = false;

// array uset to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// variable that support editDetails function
int index;
string tempMessage;
// function to change details used in Case(6)
void editDetails(int index, string temporaryMessage, string detailInformation)
{
    for (int i = 0; i < maxPets - 1; i++)
    {
        Console.WriteLine($"{ourAnimals[i, 0]}\n{ourAnimals[i, 1]}\n{ourAnimals[i, index]}");
        Console.WriteLine(new string('-', 20));
    }

    do
    {
        Console.WriteLine("Enter the ID #: ");
        readResult = Console.ReadLine();
        if (readResult != null)
            selectedPet = readResult.ToLower();
        else
            Console.WriteLine("Please select a valid ID #: ");

    } while (selectedPet == "");

    selectedPet = "ID #: " + selectedPet;
    Console.WriteLine(selectedPet);
    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 0] == selectedPet)
        {
            do
            {
                Console.Write($"Current {ourAnimals[i, index]}\nUpdate {temporaryMessage} ");
                readResult = Console.ReadLine();
                petCount = i;
            } while (readResult == null);
            detailInformation = readResult;
        }
    }
    ourAnimals[petCount, index] = temporaryMessage + detailInformation;
    Console.WriteLine("Press the Enter key to continue");
    readResult = Console.ReadLine();
}

// This function is used for searching specific pet Used in Case(7-8)
void SpecifyCharacteristic(string pet)
{
    int foundPet = 0;
    specifiedCharacteristic = "";
    // Asking for specific pet
    do
    {
        Console.WriteLine($"Search specific character of the {pet}: ");
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            specifiedCharacteristic = readResult.ToString();
        }
    } while (specifiedCharacteristic == "");

    // Looking for specified pet
    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 1] == $"Species: {pet}" && ourAnimals[i, 5].Contains(specifiedCharacteristic) ||
            ourAnimals[i, 4].Contains(specifiedCharacteristic) || ourAnimals[i, 3].Contains(specifiedCharacteristic) || ourAnimals[i, 2].Contains(specifiedCharacteristic))
        {
            Console.WriteLine();
            foundPet++;
            for (int j = 0; j < 6; j++)
                Console.WriteLine(ourAnimals[i, j]);
        }
    }

    // If pet not found
    if (foundPet >= 0)
    {
        Console.WriteLine($"Specific {pet} not found: ");
    }
}

// End of every cases
void messageEndOfResult()
{
    Console.WriteLine("\nPress the Enter key to continue");
    readResult = Console.ReadLine();
}

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
    switch (menuSelection)
    {
        case "1":
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                        Console.WriteLine(ourAnimals[i, j]);

                }
            }
            messageEndOfResult();
            break;

        case "2":
            string anotherPet = "y";
            petCount = 0;
            for (int i = 0; i < maxPets; i++)
                if (ourAnimals[i, 0] != "ID #: ")
                    petCount++;

            while (petCount < maxPets && anotherPet == "y")
            {

                if (petCount < maxPets)
                {
                    Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                }

                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                            validEntry = false;

                        else
                            validEntry = true;
                    }
                } while (validEntry == false);
                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get pet age
                do
                {
                    Console.WriteLine("Enter the pet's age or enter [?] if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                            validEntry = int.TryParse(animalAge, out petAge);

                        else
                            validEntry = true;
                    }
                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                            animalPhysicalDescription = "tbd";

                    }
                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                            animalPersonalityDescription = "tbd";

                    }
                } while (animalPersonalityDescription == "");

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                            animalNickname = "tbd";

                    }
                } while (animalNickname == "");

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                petCount++;

                // added modification
                if (petCount < maxPets)
                {
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                            anotherPet = readResult.ToLower();

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                messageEndOfResult();
            }
            break;

        case "3":
            petCount = 0;

            for (int i = 0; i < maxPets; i++)
                if (ourAnimals[i, 2] != "Age: ?" && ourAnimals[i, 2] != "Age: " && ourAnimals[i, 4] != "Physical description: " && ourAnimals[i, 4] != "Physical description: tbd") // anything with value will add petCount
                {
                    petCount++;
                }

            if (petCount < maxPets && ourAnimals[petCount, 0] != "ID #: ")
            {
                // Update Age
                if (ourAnimals[petCount, 2] == "Age: ?" || ourAnimals[petCount, 2] == "Age: ")
                {
                    animalAge = "";
                    do
                    {
                        Console.WriteLine($"Enter an age for {ourAnimals[petCount, 0]}: ");
                        readResult = Console.ReadLine();
                        if (int.TryParse(readResult, out petAge))
                        {
                            animalAge = petAge.ToString();
                        }
                    } while (animalAge == "");
                }

                // Update Physical Description
                if (ourAnimals[petCount, 4] == "Physical description: " || ourAnimals[petCount, 4] == "Physical description: tbd")
                {
                    animalPhysicalDescription = "";
                    do
                    {
                        Console.WriteLine($"Enter a physical description for {ourAnimals[petCount, 0]} (size, color, breed, gender, weight, housebroken)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalPhysicalDescription = readResult.ToLower();
                        }
                    } while (animalPhysicalDescription == "");
                }
                // update if any
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            }
            else
            {
                Console.WriteLine("Nothing to update");
            }

            Console.WriteLine("Age and physical description fields are complete for all of our friends. ");
            messageEndOfResult();
            break;

        case "4":
            petCount = 0;

            for (int i = 0; i < maxPets; i++)
                if (ourAnimals[i, 3] != "Nickname: " && ourAnimals[i, 3] != "Nickname: tbd" && ourAnimals[petCount, 5] != "Personality: " && ourAnimals[petCount, 5] != "Personality: tbd") // anything with value will add petCount
                    petCount++;

            if (petCount < maxPets && ourAnimals[petCount, 0] != "ID #:")
            {
                if (ourAnimals[petCount, 3] == "Nickname: " || ourAnimals[petCount, 3] == "Nickname: tbd")
                {
                    animalNickname = "";
                    do
                    {
                        Console.WriteLine($"Enter a nickname for {ourAnimals[petCount, 0]} ");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                            animalNickname = readResult.ToLower();

                    } while (animalNickname == "");
                }

                if (ourAnimals[petCount, 5] == "Personality: " || ourAnimals[petCount, 5] == "Personality: tbd")
                {
                    animalPersonalityDescription = "";
                    do
                    {
                        Console.WriteLine($"Enter a personality description for {ourAnimals[petCount, 0]} (likes or dislikes, tricks, energy level)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                            animalPersonalityDescription = readResult.ToLower();

                    } while (animalPersonalityDescription == "");
                }
                // Update if any
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;
            }
            else
            {
                Console.WriteLine("Nothing to update.");
            }
            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
            messageEndOfResult();
            break;

        case "5":
            selectedPet = "";
            animalAge = "";
            Console.WriteLine("Select ID #: ");
            for (int i = 0; i < maxPets - 1; i++)
            {
                Console.WriteLine($"{ourAnimals[i, 0]}\n{ourAnimals[i, 1]}\n{ourAnimals[i, 2]}");
                Console.WriteLine(new string('-', 20));
            }

            do
            {
                Console.WriteLine("Enter the ID #: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                    selectedPet = readResult.ToLower();
                else
                    Console.WriteLine("Please select a valid ID #: ");

            } while (selectedPet == "");

            selectedPet = "ID #: " + selectedPet;
            Console.WriteLine(selectedPet);
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] == selectedPet)
                {
                    do
                    {
                        Console.Write($"Current Age: {ourAnimals[i, 2]}\nUpdate Age: ");
                        readResult = Console.ReadLine();
                        petCount = i;
                    } while (!int.TryParse(readResult, out petAge));
                    animalAge = petAge.ToString();
                }
            }
            ourAnimals[petCount, 2] = "Age: " + animalAge;

            messageEndOfResult();
            break;

        case "6":
            // fill in with Index
            index = 5;
            tempMessage = "Personality: ";

            editDetails(index, tempMessage, animalPersonalityDescription);
            break;

        case "7":
            SpecifyCharacteristic("cat");

            messageEndOfResult();
            break;

        case "8":
            SpecifyCharacteristic("dog");

            messageEndOfResult();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");

