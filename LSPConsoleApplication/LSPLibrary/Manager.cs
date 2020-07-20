using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class Manager : BaseEmployee , IManaged,IManager
    {

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.50M;

            Salary = baseAmount + (rank * 2);
        }
        public IEmployee Managers { get; set; }

        public void AssignManager(IEmployee manager)
        {
            Managers = manager;
        }
        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
