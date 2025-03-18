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
    }
}
