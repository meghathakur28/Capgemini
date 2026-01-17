using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication
{
    public class Program
    {
        public EcommerceShop MakePayment(string name, double balance, double amount)
        {
            EcommerceShop ecommerceShop = new EcommerceShop();
            ecommerceShop.UserName = name;
            if (balance < amount)
            {
                throw new InsufficientWalletBalanceException("Insufficient balance in your digital wallet");
            }
            ecommerceShop.WalletBalance = balance;
            ecommerceShop.TotalPurchaseAmount = amount;
            return ecommerceShop;
        }
         public static void Main(string[] args)
         {
            Program p = new Program();
            Console.WriteLine("Enter the username: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the balance: ");
            double balance = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount: ");
            double amount = Double.Parse(Console.ReadLine());

            try
            {
                EcommerceShop eObj = p.MakePayment(name, balance, amount);
                Console.WriteLine("Payment successful");
            }
            catch(InsufficientWalletBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
         }
    }
    public class EcommerceShop
    {
        public string UserName {  get; set; }
        public double WalletBalance {  get; set; }
        public double TotalPurchaseAmount {  get; set; }
    }

    public class InsufficientWalletBalanceException:Exception
    {
        public InsufficientWalletBalanceException() { }

        public InsufficientWalletBalanceException(string message) : base(message) { }
    }
}
