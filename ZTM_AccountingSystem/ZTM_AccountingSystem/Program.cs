// See https://aka.ms/new-console-template for more information



using System.Security.Principal;
using System;
decimal transAmount = 0;
Console.WriteLine("Welcome to the Accounting System 1.0!");
Checking checking1 = new Checking(100, 0);
Console.WriteLine($"The account with id {checking1.Id} has a balance of: {checking1.Balance}");

Premium premium1 = new Premium(200, 0);
Console.WriteLine($"The account with id {premium1.Id} has a balance of: {premium1.Balance}");

checking1 = new Checking(100, 2000);
Console.WriteLine($"New balance for Account {checking1.Id} is: {checking1.Balance}");
premium1 = new Premium(200, 6000);
Console.WriteLine($"New balance for Account {premium1.Id} is: {premium1.Balance}");

transAmount =Convert.ToDecimal(Console.ReadLine());
checking1.Balance = checking1.Balance + transAmount;
premium1.Balance = premium1.Balance - transAmount;



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