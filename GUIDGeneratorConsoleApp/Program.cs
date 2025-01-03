// See https://aka.ms/new-console-template for more information
using GUIDGeneratorConsoleApp;

Console.WriteLine("Hello, World!");

Console.WriteLine($"Please enter a number here (0 for guids, 1 for uuids, 2 for ulids): ");

int choice = Convert.ToInt32(Console.ReadLine());

UIDHelper MyChoice = new((UIDHelperType)choice);

