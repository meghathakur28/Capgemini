using System;
using Assignment701;

public class Program
{
    public static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Digital Petty Cash Le");
        Console.WriteLine("----------------------");
        Console.WriteLine("1. Income Ledger");
        Console.WriteLine("2. Expense Ledger");
        Console.WriteLine("3. Exit");
        Console.ResetColor();
    }
    public static void IncomeMenu()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to Income Ledger");
        Console.WriteLine("------------------------");
        Console.WriteLine("1. Add Entry");
        Console.WriteLine("2. Get Transactions By Date");
        Console.WriteLine("3. Get Total Income ");
        Console.WriteLine("4. Exit");
        Console.ResetColor();
    }
    public static void ExpenseMenu()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Welcome to Income Ledger");
        Console.WriteLine("------------------------");
        Console.WriteLine("1. Add Entry");
        Console.WriteLine("2. Get Transactions By Date");
        Console.WriteLine("3. Get Total Expense");
        Console.WriteLine("4. Exit");
        Console.ResetColor();
    }
    public static void Main(string[] args)
    {
        decimal netBalance = 0;
        decimal totalExpense = 0;
        decimal totalIncome = 0;
        int choice = 0;
        while(choice!=3)
        {
            Menu();
            Console.WriteLine("Enter Your Choice: ");
            choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        LedgerLogic<IncomeTransaction> incomeLedger = new LedgerLogic<IncomeTransaction>();
                        int incomeChoice = 0;
                        while(incomeChoice!=4)
                        {
                            IncomeMenu();
                            Console.WriteLine("Enter the choice: ");
                            incomeChoice = Int32.Parse(Console.ReadLine());
                            switch(incomeChoice)
                            {
                                case 1:
                                    {
                                        IncomeTransaction income = new IncomeTransaction();
                                        Console.WriteLine("Enter the ID: ");
                                        income.ID = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter the Date in YY-MM-DD Format: ");
                                        income.Date = DateTime.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter the Amount: ");
                                        income.Amount = Decimal.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter the Description: ");
                                        income.Description = Console.ReadLine();
                                        Console.WriteLine("Enter the Source: ");
                                        income.Source = Console.ReadLine();
                                        incomeLedger.AddEntry(income);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Enter the Date: ");
                                        DateTime date = DateTime.Parse(Console.ReadLine());
                                        incomeLedger.GetTransactionsByDate(date);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Total Income: ");
                                        Console.WriteLine(incomeLedger.CalculateTotal());
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Thankyou for using Income Ledger");
                                        break;
                                    }
                            }
                        }
                        totalIncome = incomeLedger.CalculateTotal();
                        break;
                    }
                case 2:
                    {
                        LedgerLogic<ExpenseTransaction> expenseLedger = new LedgerLogic<ExpenseTransaction>();
                        int expenseChoice = 0;
                        while (expenseChoice != 4)
                        {
                            ExpenseMenu();
                            Console.WriteLine("Enterthe choice: ");
                            expenseChoice = Int32.Parse(Console.ReadLine());
                            switch (expenseChoice)
                            {
                                case 1:
                                    {
                                        ExpenseTransaction expense = new ExpenseTransaction();
                                        Console.WriteLine("Enter the ID: ");
                                        expense.ID = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter the Date in YY-MM-DD Format: ");
                                        expense.Date = DateTime.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter the Amount: ");
                                        expense.Amount = Decimal.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter the Description: ");
                                        expense.Description = Console.ReadLine();
                                        Console.WriteLine("Enter the category: ");
                                        expense.Category = Console.ReadLine();
                                        expenseLedger.AddEntry(expense);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Enter the Date: ");
                                        DateTime date = DateTime.Parse(Console.ReadLine());
                                        expenseLedger.GetTransactionsByDate(date);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Total Expense: ");
                                        Console.WriteLine(expenseLedger.CalculateTotal());
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Thankyou for using Expense Ledger");
                                        break;
                                    }
                            }
                        }
                        totalExpense = expenseLedger.CalculateTotal();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("NetBalance: ", totalIncome - totalIncome);
                        Console.WriteLine("Thankyou");
                        break;
                    }
            }
        }
    }
}
