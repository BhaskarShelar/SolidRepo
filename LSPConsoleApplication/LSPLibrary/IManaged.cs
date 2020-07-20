using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public interface IManaged:IEmployee
    {
        IEmployee Managers { get; set; }
        void AssignManager(IEmployee manager);
    }
}
