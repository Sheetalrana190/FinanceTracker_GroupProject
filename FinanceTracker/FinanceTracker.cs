using System;
using System.Collections.Generic;

namespace FinanceTracker
{
    // Enum for transaction types
    public enum TransactionType
    {
        Income,
        Expense
    }

    // Abstract class for a financial transaction
    public abstract class Transaction
    {
        // Properties
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }

        // Constructor
        public Transaction(DateTime date, decimal amount, TransactionType type)
        {
            Date = date;
            Amount = amount;
            Type = type;
        }
    }
}