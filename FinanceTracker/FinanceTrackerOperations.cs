using System;
using System.Collections.Generic;

namespace FinanceTracker
{
    public class FinanceTrackerOperations
    {
        // Method to find a transaction by date
        public Transaction FindTransactionByDate(List<Transaction> transactions, DateTime date)
        {
            foreach (var transaction in transactions)
            {
                if (transaction.Date == date)
                {
                    return transaction;
                }
            }
            return null;
        }

        // Method to remove a transaction by date
        public bool RemoveTransactionByDate(List<Transaction> transactions, DateTime date)
        {
            var transaction = FindTransactionByDate(transactions, date);
            if (transaction != null)
            {
                transactions.Remove(transaction);
                return true;
            }
            return false;
        }

        // Method to handle errors
        public void HandleError(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Method to display transactions within a date range
        public void DisplayTransactionsByDateRange(List<Transaction> transactions, DateTime startDate, DateTime endDate)
        {
            foreach (var transaction in transactions)
            {
                if (transaction.Date >= startDate && transaction.Date <= endDate)
                {
                    transaction.DisplayTransaction();
                }
            }
        }

        // Method to sort transactions by amount
        public void SortTransactionsByAmount(List<Transaction> transactions)
        {
            transactions.Sort((x, y) => x.Amount.CompareTo(y.Amount));
        }
    }
}