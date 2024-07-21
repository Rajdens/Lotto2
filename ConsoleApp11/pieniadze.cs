using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Pieniadze
    {
        public int Money()
        {
            bool UdaloSie = false;
            int a = 0;

            while (UdaloSie == false)
            {
                Console.WriteLine("Proszę podać posiadaną ilość pieniędzy");
                string parse = Console.ReadLine();
                if (int.TryParse(parse, out int result))
                {
                    if (result >= 25)
                    {
                        Console.WriteLine($"udało się pobrać ilość pieniędzy, posiadasz {result} PLN.");
                        UdaloSie = true;
                    }
                }
                else
                {
                    Console.WriteLine("nie udało się pobrać pieniędzy, Wpisuj tylko cyfry.");
                }
                if (result < 25)
                {
                    Console.WriteLine("Podałeś zbyt małą ilość pieniędzy. 1 losowanie kosztuje 25 zł.");
                }

                a = result;
            }
            return a;
        }
    }
}
