
using DILibrary;

using System;

namespace ConsoleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Bhaskar";
            owner.LastName = "shelar";
            owner.EmailAddress = "bhaskar.Shelar@e-zes.in";
            owner.PhoneNumber = "99999-9999";

            IServent Servent = Factory.CreateSevernt();
            Servent.ServentName = "suhsil";
            Servent.Owner = owner;
           

            Servent.PerformedWork(3);
            Servent.PerformedWork(1.5);
            Servent.CompleteChore();

            Console.ReadLine();
        }
    }
}
