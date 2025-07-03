// See https://aka.ms/new-console-template for more information
Console.Write("Enter name: ");
string name = Console.ReadLine();

Console.Write("Enter lastname: ");
string surname = Console.ReadLine();

if (name[0] == surname[0])
    Console.WriteLine("Last name begins with the same letter as first name");
else
    Console.WriteLine("The last name does not start with the same letter as the first name");