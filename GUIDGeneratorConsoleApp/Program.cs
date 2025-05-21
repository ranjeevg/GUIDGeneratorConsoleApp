// See https://aka.ms/new-console-template for more information
using GUIDGeneratorConsoleApp;
using static System.Ulid;

Console.WriteLine("Hello, World!");
Console.WriteLine($"Please enter a number here (1 for GUIDs, 2 for UUIDs, or 3 for ULIDs): ");

List<int> possibleChoices = [1, 2, 3];

int choice;

bool SuccessfullyParsed = System.Int32.TryParse(Console.ReadLine(), out choice);

if (!SuccessfullyParsed || !possibleChoices.Contains(choice))
{
    Console.WriteLine("Unable to parse GUID type. The program will close - please reopen it and try again.");
    Thread.Sleep(1500);
    return;
}

UIDHelperType userChoice = (UIDHelperType)(choice);
UIDHelper MyChoice = new(userChoice);

string UIDString = String.Empty;

// read in the number of UIDs of the specified type to create
Console.WriteLine($"Please enter the number of {MyChoice.UIDType}s to generate: ");

// default value - in case user input fails
SuccessfullyParsed = Int32.TryParse(Console.ReadLine(), out int NumOfUIDsToGenerate);

if (!SuccessfullyParsed)
{
    Console.WriteLine($"Unable to parse input. The program will close - please reopen it and try again.");
    Thread.Sleep(1500);
    return;
}

if (!possibleChoices.Contains(choice))
{
    Console.WriteLine($"Invalid option chosen: {choice}. The program will close - please reopen it and try again.");
    Thread.Sleep(1500);
    return;
}

else
{
    Console.WriteLine();
    Console.WriteLine($"You have chosen to generate unique identifiers of type {MyChoice.UIDType}.");
    Console.WriteLine($"We have generated {NumOfUIDsToGenerate} {MyChoice.UIDType}s for you.");
    Console.WriteLine();

    for (int i = 0; i < NumOfUIDsToGenerate; i++)
    {
        switch (MyChoice.UIDType)
        {
            case UIDHelperType.GUID:
                {
                    UIDString = Guid.NewGuid().ToString();
                    break;
                }
            case UIDHelperType.UUID:
                {
                    UIDString = Medo.Uuid7.NewMsSqlUniqueIdentifier().ToString();
                    break;
                }
            case UIDHelperType.ULID:
                {
                    UIDString = Ulid.NewUlid().ToString();
                    break;
                }
        }

        Console.WriteLine($"{MyChoice.UIDType} #{i + 1}: \n{UIDString}\n");
    }
}

Console.WriteLine("Press any key to exit:");
Console.ReadKey();