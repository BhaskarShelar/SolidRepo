using System;
using System.Collections.Generic;
using System.Text;

namespace DILibrary
{
    public class Servent : IServent
    {
        private readonly ILogger _Ilogger;
        private readonly ISender _Isender;

        public string ServentName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Servent(ILogger logger,ISender sender)
        {
            this._Ilogger = logger;
            this._Isender = sender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _Ilogger.Log($"Performed work on { ServentName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;

           _Ilogger.Log($"Completed { ServentName }");

            _Isender.SendMessage(Owner, $"The Servent { ServentName } is complete.");
        }
    }
}
