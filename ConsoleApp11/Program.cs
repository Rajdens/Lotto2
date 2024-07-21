using ConsoleApp11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pieniadze check = new Pieniadze();
            int ile = check.Money();
            Console.WriteLine(" ");

            Ilosc ilosci = new Ilosc();
            int losowania = ilosci.IleRazy(ile);

            HowMany ilerazy = new HowMany();
            int mnozyc = ilerazy.IleRazy(losowania);

            Numbers wykonaj = new Numbers();
            List<int> ilosc = wykonaj.Liczby();

            Rng generuj = new Rng();
            List<int> generowane = generuj.GenerujLiczbyLosowe(6, 1, 50);

            Wygrana sprawdz = new Wygrana();
            int liczby = sprawdz.SprawdzLiczby(ilosc, generowane);
            
            IleGrane Many = new IleGrane();
            Many.IleGier(mnozyc, liczby, generowane);
        }
    }
}

