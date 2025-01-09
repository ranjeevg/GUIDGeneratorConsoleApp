// See https://aka.ms/new-console-template for more information
using GUIDGeneratorConsoleApp;
using static System.Ulid;

Console.WriteLine("Hello, World!");
Console.WriteLine($"Please enter a number here (0 for guids, 1 for uuids, 2 for ulids): ");

int choice = Convert.ToInt32(Console.ReadLine());

UIDHelperType userChoice = (UIDHelperType)(choice);
UIDHelper MyChoice = new(userChoice);

string UIDString = String.Empty;

var random = new Random();
int NumOfUIDsToGenerate = random.Next(2, 6);

Console.WriteLine();
Console.WriteLine($"Out of sheer impulsiveness, we have chosen to generate {NumOfUIDsToGenerate} UIDs of type {MyChoice.UIDType}");
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
        default:
        {
            Console.WriteLine($"Unrecognized UID type selected: {choice}");
            break;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Your unique identifier: \n\n{UIDString}");
}

Console.ReadLine();

