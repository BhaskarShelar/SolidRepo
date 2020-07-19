using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedLibrary
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts accounts { get; set; } = new ManageAccount();
       
    }
}
