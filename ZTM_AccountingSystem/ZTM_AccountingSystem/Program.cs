// See https://aka.ms/new-console-template for more information



using System.Security.Principal;
using System;
decimal transAmount = 0;
Console.WriteLine("Welcome to the Accounting System 1.0!");

Checking checking1 = new Checking(100, 0);
Premium premium1 = new Premium(200, 0);
string ans = "y";

do
{
    Console.WriteLine("Select a number : Do you want to make a\n 1. Deposit\n 2. Transfer\n 3. Check balance");
    char userSelection = Convert.ToChar(Console.ReadLine());
    switch (userSelection)
    {
        case '1':
            Console.WriteLine("Deposit");
            Console.WriteLine("Choose an Account you want to make a Deposit to:\n 1. Checking\n 2. Premium");
            char userSel = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("How much do you want to deposit");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());
            if (userSel == '1')
            {
                checking1 = new Checking(100, deposit);

            }
            else if (userSel == '2')
            {
                premium1 = new Premium(200, deposit);
            }

            break;
        case '2':
            Console.WriteLine("transfer");
            TransferMoney();
            break;
        case '3':
            Console.WriteLine("Check Balance");
            CheckBalance();
            break;
        default:
            Console.WriteLine("Thank You");
            break;
    }
    Console.WriteLine("Do you want to continue (y) or end (n)");
    ans = Console.ReadLine().ToLower();

}
while (ans == "y");

void TransferMoney()
{
    Console.WriteLine("Transfer from\n 1. Checking\n 2. Premium");
    string userAns = Console.ReadLine();
    if (userAns == "1")
    {
        Console.WriteLine("You are transfering from Checking to Premium");
        Console.WriteLine("How much do you want to transfer? ");
        transAmount = Convert.ToDecimal(Console.ReadLine());
        checking1.Balance = checking1.Balance - transAmount;
        premium1.Balance = premium1.Balance + transAmount;
    }
    else 
    { 
        Console.WriteLine("You are transfering from Premium to checking");
        Console.WriteLine("How much do you want to transfer? ");
        transAmount = Convert.ToDecimal(Console.ReadLine());
        checking1.Balance = checking1.Balance + transAmount;
        premium1.Balance = premium1.Balance - transAmount;
    }
}

Console.WriteLine($"New balance for Account {checking1.Id} is: {checking1.Balance}");

Console.WriteLine($"New balance for Account {premium1.Id} is: {premium1.Balance}");





InterestRate(checking1.Id, checking1.Balance);
InterestRate(premium1.Id, premium1.Balance);

static void InterestRate(int id, decimal balance)
{
    decimal iRate = .03M;
    decimal calIrate = (balance * iRate) + balance;
    if(id == 100)
    {
        Console.WriteLine($"Account1 interst: {calIrate.ToString()}");
    }
    else
    {
        calIrate = (balance * 0.01M) + calIrate;
        Console.WriteLine($"Account2 interst: {calIrate.ToString()}");
    }
    

}

void CheckBalance()
{
    Console.WriteLine($"The account with id {checking1.Id} has a balance of: {checking1.Balance}");
    Console.WriteLine($"The account with id {premium1.Id} has a balance of: {premium1.Balance}");
}

public class Checking
{
    public int Id {  get; set; }
    public decimal Balance { get; set; }
    public Checking(int id, decimal balance)
    {
        Id = id;
        Balance = balance;
    }


   
}

public class Premium : Checking
{
    public Premium(int id, decimal balance) : base(id, balance)
    {
    }
}