using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Potwierdz : Numbers
    {
        public int Potwierdzasz()
        {
            bool czy = false;
            int a = 0;

            Console.WriteLine("Czy potwierdzasz wybór Swoich liczb?");
            Console.WriteLine("1. potwierdzam.");
            Console.WriteLine("2. Nie, chcę wybrać je ponownie.");
            while (czy == false)
            {
                string Choice = Console.ReadLine();
                if (!int.TryParse(Choice, out int result))
                {
                    Console.WriteLine("Podano literę bądź błędny znak.");
                    continue;
                }
                if (result > 2 || result < 0)
                {
                    Console.WriteLine("Podałeś złą liczbę.");
                    continue;
                }
                a = result;
                czy = true;
            }


            return a;
        }
    }
}
