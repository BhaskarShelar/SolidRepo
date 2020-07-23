
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibraary
{
   public interface IDVD:IBook,IlibraryrItem
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}
