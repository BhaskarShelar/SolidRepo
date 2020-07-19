    using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedLibrary
{
    public class Accounts : IAccounts
    {
        public Employee Create(IApplicantModel person)
        {
            Employee employee = new Employee();
            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{ person.FirstName }.{person.LastName}@abcd.com";
            

            return employee;
        }
    }
}
