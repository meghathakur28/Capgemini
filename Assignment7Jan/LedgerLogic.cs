using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment701
{
    public class LedgerLogic<T>
    {
        private List<T> transactions;
        public LedgerLogic()
        {
            transactions = new List<T>();
        }
        public void AddEntry(T entry)
        {
            transactions.Add(entry);
        }
        public List<T> GetTransactionsByDate(DateTime date)
        {
            List<T> result = new List<T>();
            foreach (var t in transactions)
            {
                dynamic dynT = t;
                if (dynT.Date.Date == date.Date)
                {
                    result.Add(t);
                }
            }
            return result;
        }
        public decimal CalculateTotal()
        {
            decimal sum = 0;
            foreach(var t in transactions)
            {
                dynamic dynT = t;
                sum += dynT.Amount;
            }
            return sum;
        }
    }
}
