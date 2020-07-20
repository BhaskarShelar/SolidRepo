using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class Employee : BaseEmployee,IManaged
    {

        public IEmployee Managers { get; set; }

        public void AssignManager(IEmployee manager)
        {
            Managers = manager;
        }
    }
}
