using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment701
{
    public class ExpenseTransaction : Transaction,IReportable
    {
        public override int ID { get; set; }
        public override DateTime Date { get; set; }
        public override decimal Amount { get; set; }
        public override string Description { get; set; }

        public string Category { get; set; }

        public void GetSummary()
        {
            Console.WriteLine($"Expense ID: {ID}, Date: {Date}, Amount: {Amount}, Description: {Description}, Category: {Category}");
        }
    }
}
