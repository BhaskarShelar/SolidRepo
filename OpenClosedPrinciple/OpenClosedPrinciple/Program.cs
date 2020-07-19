using OpenClosedLibrary;

using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Bhaskar", LastName = "Shelar" },
                new ManagerModel { FirstName = "Devendra", LastName = "Bendale" },
                new TopExecutive { FirstName = "Vaibhav", LastName = "Vyvahare"}
            };

            List<Employee> employees = new List<Employee>();
          
            foreach (var person in applicants)
            {
                employees.Add(person.accounts.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager :{emp.IsManager}  IsTopExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
