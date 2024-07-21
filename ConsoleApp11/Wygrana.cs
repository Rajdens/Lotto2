using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Wygrana : Program
    {

            public int SprawdzLiczby(List<int> liczbyUzytkownika, List<int> liczbyWylosowane)
            {
            int wspolneLiczby = 0;

                foreach (int liczba in liczbyUzytkownika)
                {
                    if (liczbyWylosowane.Contains(liczba))
                    {
                    wspolneLiczby++;
                    }
                }

            return wspolneLiczby;
            }
    }
}
