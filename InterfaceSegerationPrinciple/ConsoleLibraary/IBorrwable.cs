using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibraary
{
    public interface IBorrwable
    {
        int CheckOutDurationInDays { get; set; }
        string Borrower { get; set; }
        DateTime BorrowDate { get; set; }

        void CheckOut(string borrower);

        void CheckIn();
        DateTime GetDueDate(); 
    }
}
