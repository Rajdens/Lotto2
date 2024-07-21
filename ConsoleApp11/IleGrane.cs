using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class IleGrane
    {
        public int IleGier(int ile, int wspolneliczby, List<int> losowane)
        {
            int suma = ile * wspolneliczby;
            bool czy = false;
            int a = 0;

            Console.WriteLine("Czy chcesz sprawdzić możliwość wygranych?");
            Console.WriteLine("1. Tak, pokaż mi.");
            Console.WriteLine("2. Nie, sprawdź ile wygrałem");
            while (czy == false)
            {
                string pobierz = Console.ReadLine();
                if (!int.TryParse(pobierz, out int result))
                {
                    Console.WriteLine("Podano literę bądź błędny znak.");
                    continue;
                }

                if (result <= 0 || result >= 4)
                {
                    Console.WriteLine("Podano zbyt dużą / zbyt małą liczbę!");
                    continue;
                }
                czy = true;
                a = result;
            }
            if (a == 1)
            {
                Console.Clear();
                Console.WriteLine("3 liczby: 10zł");
                Console.WriteLine("4 liczby: 100zł");
                Console.WriteLine("5 liczb: 3 500zł");
                Console.WriteLine("6 liczb: 1 000 000 zł \n");
            }


            Console.Write("Liczby w dzisiejszej kumulacji to: ");
            foreach (int i in losowane)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            switch (wspolneliczby)
                {
                    case 0:
                        {
                            Console.WriteLine("Nie trafiłeś żadnej liczby. Nie wygrałeś nic. Próbuj dalej!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Trafiłeś tylko jedną liczbę. Nie wygrałeś nic. Próbuj dalej!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Trafiłeś tylko dwie liczby. Nie wygrałeś nic. Próbuj dalej!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Trafiłeś Trzy liczby! Wygrałeś!");
                            Console.WriteLine($"Wygrana: {suma * 3} PLN");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Trafiłeś Cztery liczby! Wygrałeś!!!");
                            Console.WriteLine($"Wygrana: {suma * 4} PLN");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Trafiłeś pięć liczb!! Wygrałeś!!!");
                            Console.WriteLine($"Wygrana: {suma * 5} PLN");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Trafiłeś sześć liczb!!!!! Wygrałeś!!!");
                            Console.WriteLine($"Wygrana: {suma * 6} PLN");
                            break;
                        }
                }
                return suma;
        }
    }
}