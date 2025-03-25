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



    }
}
