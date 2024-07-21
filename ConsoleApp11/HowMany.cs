using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class HowMany
    {
        public int IleRazy(int losowania)
        {
            Console.WriteLine("Ile razy chcesz zagrać?");
            bool udaloSie = false;
            int ileLosowan = 0;

            while (udaloSie == false)
            {
                string ile = Console.ReadLine();
                if (!int.TryParse(ile, out int result))
                {
                    Console.WriteLine("Podano literę bądź błędny znak.");
                    continue;
                }
                if (result > losowania)
                {
                    Console.WriteLine("Podałeś nieprawidłową liczbę losowań.");
                    continue;
                }
                if(result <= 0)
                {
                    Console.WriteLine($"Musisz wybrać ile razy chcesz zalosować! możesz wybrać od 1 do {losowania} razy.");
                    continue;
                }
                ileLosowan = result;
                udaloSie = true;
            }
            return ileLosowan;
        }
    }
}
