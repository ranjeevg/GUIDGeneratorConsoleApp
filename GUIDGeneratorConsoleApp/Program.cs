// See https://aka.ms/new-console-template for more information
using GUIDGeneratorConsoleApp;
using Medo;
using static System.Ulid;

Console.WriteLine("Hello, World!");
Console.WriteLine($"Please enter a number here (0 for guids, 1 for uuids, 2 for ulids): ");


int choice = Convert.ToInt32(Console.ReadLine());

UIDHelperType userChoice = (UIDHelperType)(Convert.ToInt32(Console.ReadLine()));
UIDHelper MyChoice = new (userChoice);

string UIDString = "";

switch(MyChoice.UIDType)
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

Console.WriteLine($"Your unique identifier: \n\n{UIDString}");

