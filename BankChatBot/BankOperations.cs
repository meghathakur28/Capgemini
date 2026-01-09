using System;
using System.Collections.Generic;
using System.Text;

namespace BankChatBot
{
    public class BankOperations: IBankAccountOperation
    {
        decimal balance = 0;
        public void Deposit(decimal d)
        {
            balance += d;
        }
        public decimal ProcessOperation(string message)
        {
            if(message.ToLower().Contains("see")|| message.ToLower().Contains("view")|| message.ToLower().Contains("show"))
            {
                return balance;
            }
            else if(message.ToLower().Contains("deposit")|| message.ToLower().Contains("put")|| message.ToLower().Contains("invest")|| message.ToLower().Contains("transfer"))
            {
                var words = message.Split(' ');
                foreach(var word in words)
                {
                    if(decimal.TryParse(word, out decimal amount))
                    {
                        Deposit(amount);
                        return balance;
                    }
                }
            }
            else if(message.ToLower().Contains("withdraw")||message.ToLower().Contains("pull"))
            {
                var words = message.Split(' ');
                foreach(var word in words)
                {
                    if(decimal.TryParse(word, out decimal amount))
                    {
                        Withdraw(amount);
                        return balance;
                    }
                }
            }
            return balance;
        }
        public void Withdraw(decimal d)
        {
            balance -= d;
        }
    }
}
