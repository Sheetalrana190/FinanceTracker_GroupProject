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

    }
}
