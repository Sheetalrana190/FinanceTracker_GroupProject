﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTracker
{
    public static class FinanceTrackerUtilities
    {
        // Method to format currency
        public static string FormatCurrency(decimal amount)
        {
            return string.Format("{0:C}", amount);
        }
        // Method to display menu options
        public static void DisplayMenu()
        {
            Console.WriteLine("Finance Tracker Menu:");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. Display All Transactions");
            Console.WriteLine("4. Display Transactions by Type");
            Console.WriteLine("5. Display Summary");
            Console.WriteLine("6. Exit");
        }
        // Method to handle menu selection
        public static void HandleMenuSelection(FinanceTrackerUI ui)
        {
            bool exit = false;
            while (!exit)
            {
                DisplayMenu();
                Console.Write("Select an option: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddIncome(ui);
                            break;
                        case 2:
                            AddExpense(ui);
                            break;
                        case 3:
                            ui.DisplayAllTransactions();
                            break;
                        case 4:
                            DisplayTransactionsByType(ui);
                            break;
                        case 5:
                            ui.DisplaySummary();
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
