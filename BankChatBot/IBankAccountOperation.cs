using System;
using System.Collections.Generic;
using System.Text;

namespace BankChatBot
{
    public interface IBankAccountOperation
    {
        void Deposit(decimal d);
        void Withdraw(decimal d);
        decimal ProcessOperation(string message);

    }
}
