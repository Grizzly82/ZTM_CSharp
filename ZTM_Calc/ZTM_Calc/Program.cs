// See https://aka.ms/new-console-template for more information
/*
 * Ask the user for two numbers and a calculation method.
Valid calculation methods are addition, subtraction, multiplication, and division.
After the user has input their information, calculate the result and print it on the console.
After the result has been printed, ask the user for another calculation. 
    The program should only end if the user decides that he does not want to calculate another result.
*/

Console.WriteLine("Welcome to the ZTM Calculator");
char ans = 'y';
do
{

    Console.WriteLine("Please enter a number:");
    int? number1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter another number:");
    int? number2 = Int32.Parse(Console.ReadLine());

    Console.WriteLine("");
    Console.WriteLine("Do you want to \n 1) Add \n 2) Subtract \n 3) Multiply \n 4) Divide");
    string? operation = Console.ReadLine();

    int? result = 0;

    switch (operation)
    {
        case "Add":
            result = number1 + number2;
            break;
        case "Subtract":
            result = number1 - number2;
            break;
        case "Multiply":
            result = number1 * number2;
            break;
        case "Divide":
            try
            {
                result = number1 / number2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                //throw;
            }

            break;
    }
    Console.WriteLine($"The result of {operation} was {result}");

    Console.WriteLine("\n\n");
    Console.WriteLine("Do you want to do another calculation? y/n");
    ans = Char.Parse(Console.ReadLine());
}
while (ans == 'y');
