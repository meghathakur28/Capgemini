using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransaction_9
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the balance: ");
            int balance = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enterthe number of transaction: ");
            int n = Int32.Parse(Console.ReadLine());

            int[] transaction = new int[n];

            for(int i=0;i<n;i++)
            {
                transaction[i] = Int32.Parse(Console.ReadLine());
                if (transaction[i] > 0)
                {
                    balance += transaction[i];
                }
                else
                {
                    if (balance >= transaction[i])
                    {
                        balance += transaction[i];
                    }
                }
            }

            Console.WriteLine("Final balance: " + balance);
        }
    }
}
