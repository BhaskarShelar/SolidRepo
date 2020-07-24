using System;
using System.Collections.Generic;
using System.Text;

namespace DILibrary
{
    public class TextSender : ISender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"sending text message to { person.EmailAddress }");
        }
    }
}