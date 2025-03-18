using System;
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
    }
}
