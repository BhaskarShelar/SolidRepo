using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibraary
{
    public interface IBook:IlibraryrItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
