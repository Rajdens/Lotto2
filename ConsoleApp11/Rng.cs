using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Rng : Program
    {

        public List<int> GenerujLiczbyLosowe(int count, int min, int max)
        {
            List<int> numbers = new List<int>();
            Random random = new Random();

            
            while (numbers.Count < count)
            {
                int nowaliczba = random.Next(min, max + 1);
                if (!numbers.Contains(nowaliczba))
                {
                    numbers.Add(nowaliczba);
                }
            }   
            return numbers;
        }
    }
}
