using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibraary
{
   public interface IAudioBook:IlibraryrItem,IBook, IBorrwable
    {
         int RuntimeInMinutes { get; set; }
    }
}
