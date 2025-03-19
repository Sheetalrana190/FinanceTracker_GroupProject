using System;
using System.Collections.Generic;

namespace FinanceTracker
{
    // Interface for generating reports
    public interface IReportGenerator
    {
        void GenerateReport(List<Transaction> transactions);
    }

    // Class for generating detailed reports
    public class DetailedReportGenerator : IReportGenerator
    {
        // Implementing the interface method
        public void GenerateReport(List<Transaction> transactions)
        {
            Console.WriteLine("Detailed Report:");
            foreach (var transaction in transactions)
            {
            //    transaction.DisplayTransaction();
            }
        }

        // Overloaded method to generate report for a specific type
        public void GenerateReport(List<Transaction> transactions, TransactionType type)
        {
            Console.WriteLine($"Detailed Report for {type}:");
            foreach (var transaction in transactions)
            {
                if (transaction.Type == type)
                {
                //    transaction.DisplayTransaction();
                }
            }
        }
    }

    // Class for generating summary reports
    public class SummaryReportGenerator : IReportGenerator
    {
        // Implementing the interface method
        public void GenerateReport(List<Transaction> transactions)
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;

            foreach (var transaction in transactions)
            {
                if (transaction.Type == TransactionType.Income)
                {
                    totalIncome += transaction.Amount;
                }
                else if (transaction.Type == TransactionType.Expense)
                {
                    totalExpenses += transaction.Amount;
                }
            }

            decimal balance = totalIncome - totalExpenses;

            Console.WriteLine("Summary Report:");
            Console.WriteLine($"Total Income: {totalIncome:C}");
            Console.WriteLine($"Total Expenses: {totalExpenses:C}");
            Console.WriteLine($"Balance: {balance:C}");
        }
    }
}