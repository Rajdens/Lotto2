using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Numbers : Program
    {
        public List<int> Liczby()
        {
            List<int> liczby = new List<int>();

            bool potwierdzenie = false;

            while (potwierdzenie == false)
            {
                while (liczby.Count < 6)
                {
                    Console.WriteLine($"Proszę podać {liczby.Count + 1} liczbę z przedziału 1-49 wyznaczoną do udziału w losowaniu.");
                    string pobierz = Console.ReadLine();

                    if (!int.TryParse(pobierz, out int result))
                    {
                        Console.WriteLine("Podano literę bądź błędny znak.");
                        continue;
                    }

                    if (result <= 0 || result >= 50)
                    {
                        Console.WriteLine("Podano zbyt dużą / zbyt małą liczbę!");
                        continue;
                    }


                    if (liczby.Contains(result))
                    {
                        Console.WriteLine("podana liczba znajduje się już w liście.");
                        continue;
                    }


                    liczby.Add(result);
                }
                Console.Write("podane liczby to: ");
                foreach (int i in liczby)
                {
                    Console.Write(i + " ");
                }

                Potwierdz test = new Potwierdz();
                int sprawdz = test.Potwierdzasz();
                if (sprawdz == 1)
                {
                    potwierdzenie = true;
                }
                else if (sprawdz == 2)
                {
                    Console.Clear();
                    liczby.Clear();
                }
            }

            return liczby;

        }
    }
}
