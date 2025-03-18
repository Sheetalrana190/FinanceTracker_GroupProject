using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTracker
{
    class FinanceTrackerReports
    {
    }
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
                //  transaction.DisplayTransaction();
            }
        }

    }
}
