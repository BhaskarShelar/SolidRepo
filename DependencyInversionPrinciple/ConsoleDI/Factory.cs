using DILibrary;

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDI
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        public static IServent CreateSevernt()
        {
            return new Servent(CreateLogger(),CreateSender());
        }
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
        public static ISender CreateSender()
        {
            return new TextSender();
        }
    }
}
