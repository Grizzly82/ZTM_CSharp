// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n = 0;
while (n < 21)
{
    n++;

    if ( n > 9)
    {
        Console.WriteLine($"This is the value n: {n}");

    }
}
Console.WriteLine("The the loop is over :)");

Console.WriteLine("How old are you?");
var age = Console.ReadLine();
Console.WriteLine($"Happy Birthday, you are {age} years old");