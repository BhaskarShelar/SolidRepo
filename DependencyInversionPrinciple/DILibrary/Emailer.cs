using System;
using System.Collections.Generic;
using System.Text;

namespace DILibrary
{
    public class Emailer : ISender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to { person.EmailAddress }");
        }
    }
}
