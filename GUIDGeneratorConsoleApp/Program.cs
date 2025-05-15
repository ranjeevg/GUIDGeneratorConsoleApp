// See https://aka.ms/new-console-template for more information
using GUIDGeneratorConsoleApp;
using static System.Ulid;

Console.WriteLine("Hello, World!");
Console.WriteLine($"Please enter a number here (1 for GUIDs, 2 for UUIDs, or 3 for ULIDs): ");

int choice = Convert.ToInt32(Console.ReadLine());

UIDHelperType userChoice = (UIDHelperType)(choice);
UIDHelper MyChoice = new(userChoice);

string UIDString = String.Empty;

List<int> possibleChoices = [1, 2, 3];

var random = new Random();
int NumOfUIDsToGenerate = 5;



if (!possibleChoices.Contains(choice))
    Console.WriteLine($"Invalid option chosen: {choice}. Please close and reopen this scriptlet.");
else
{
    Console.WriteLine();
    Console.WriteLine($"You have chosen to generate unique identifiers of type {MyChoice.UIDType}.");
    Console.WriteLine($"We have generated {NumOfUIDsToGenerate} {MyChoice.UIDType}s for you.");
    Console.WriteLine();
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

        Console.WriteLine();
        Console.WriteLine($"Your unique identifier: \n\n{UIDString}");
    }
}

Console.ReadLine();

