using LSPLibrary;

using System;

namespace LSPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Bhaskar";
            accountingVP.LastName = "Shelar";
            accountingVP.CalculatePerHourRate(4);
            //Console.WriteLine($"{ accountingVP.FirstName }'s salary is ${ accountingVP.Salary }/hour.");


            IManager emp = new CEO();

            emp.FirstName = "vaibhav";
            emp.LastName = "Shelar";
            //emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");


            Console.ReadLine();
        }
    }
}
