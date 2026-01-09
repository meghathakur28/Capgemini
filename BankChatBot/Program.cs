using System;
using BankChatBot;

class Progaram
{
    public static void Main(string[] args)
    {
        IBankAccountOperation bankAccount = new BankOperations();
        Console.WriteLine("Welcome to the Bank Chat Bot!");
        Console.WriteLine("You can deposit, withdraw, or view your balance.");
        Console.WriteLine("Type 'exit' to quit the application.");
        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }
            decimal balance = bankAccount.ProcessOperation(input);
            Console.WriteLine($"Bot: Your current balance is {balance}");
        }
        Console.WriteLine("Thank you for using the Bank Chat Bot. Goodbye!");
    }
}