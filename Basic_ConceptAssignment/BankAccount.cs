using System;
namespace Assignment2
{
    public class BankAccount
    {
        public static void Account()
        {
            Console.Write("Enter the initial balance: ");
            int initialBalance = Int32.Parse(Console.ReadLine());
            int[] transactions = new int[5];
            Console.WriteLine("Enter the transactions");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Transaction " + (i + 1) + ": ");
                transactions[i] = Int32.Parse(Console.ReadLine());
                if (transactions[i] < 0)
                {
                    if (-transactions[i] > initialBalance)
                    {
                        Console.WriteLine("Insufficient funds for withdrawal of " + (transactions[i]) + ".");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Withdrawal of " + (transactions[i]) + " processed.");
                    }
                }
                else
                {
                    Console.WriteLine("Deposit of " + transactions[i] + " processed.");
                }

                initialBalance += transactions[i];
                Console.WriteLine("Updated balance: " + initialBalance);
            }
            Console.WriteLine("Final balance: " + initialBalance);
        }
        }
    }