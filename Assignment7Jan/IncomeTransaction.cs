using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment701
{
    public class IncomeTransaction:Transaction,IReportable
    {
        public override int ID { get; set; }
        public override DateTime Date { get; set; }
        public override decimal Amount { get; set; }
        public override string Description { get; set; }
        public string Source { get; set; }

        public void GetSummary()
        {
            Console.WriteLine($"Income ID: {ID}, Date: {Date}, Amount: {Amount}, Description: {Description}, Source: {Source}");
        }
    }
}
