using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Ilosc
    {
        public int IleRazy(int kasa)
        {
            int IleMamy = kasa / 25;
            Console.WriteLine($"Stać cię na {IleMamy} losowań.");
            return IleMamy;
        }
    }
}
