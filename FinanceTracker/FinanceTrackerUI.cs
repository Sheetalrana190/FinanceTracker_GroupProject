using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTracker
{
    public class FinanceTrackerUI
    {
        // List to store transactions
        private List<Transaction> transactions;

        // Constructor
        public FinanceTrackerUI()
        {
            transactions = new List<Transaction>();
        }

        // Method to add a transaction
        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
            Console.WriteLine("Transaction added successfully.");
        }

        // Method to display all transactions
        public void DisplayAllTransactions()
        {
            foreach (var transaction in transactions)
            {
                transaction.DisplayTransaction();
            }
        }

        // Method to display transactions by type
        public void DisplayTransactionsByType(TransactionType type)
        {
            foreach (var transaction in transactions)
            {
                if (transaction.Type == type)
                {
                    transaction.DisplayTransaction();
                }
            }
        }

        // Method to calculate total income
        public decimal CalculateTotalIncome()
        {
            decimal totalIncome = 0;
            foreach (var transaction in transactions)
            {
                if (transaction.Type == TransactionType.Income)
                {
                    totalIncome += transaction.Amount;
                }
            }
            return totalIncome;
        }

        // Method to calculate total expenses
        public decimal CalculateTotalExpenses()
        {
            decimal totalExpenses = 0;
            foreach (var transaction in transactions)
            {
                if (transaction.Type == TransactionType.Expense)
                {
                    totalExpenses += transaction.Amount;
                }
            }
            return totalExpenses;
        }

        // Method to display summary
        public void DisplaySummary()
        {
            decimal totalIncome = CalculateTotalIncome();
            decimal totalExpenses = CalculateTotalExpenses();
            decimal balance = totalIncome - totalExpenses;

            Console.WriteLine($"Total Income: {totalIncome:C}");
            Console.WriteLine($"Total Expenses: {totalExpenses:C}");
            Console.WriteLine($"Balance: {balance:C}");
        }
    }
}
