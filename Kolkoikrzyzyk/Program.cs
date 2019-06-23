using Gra.Logika;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolkoikrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*===============KÓŁKO I KRZYŻYK===============*");
            Console.WriteLine("       Witaj w grze Kółko i Krzyżyk!");

            Console.Write("Podaj imię pierwszego gracza: ");
            string gracz1 = Console.ReadLine();

            Console.Write("Podaj imię drugiego gracza: ");
            string gracz2 = Console.ReadLine();

            var gra = new KolkoKrzyzyk(gracz1, gracz2);

            gra.Uruchom();
        } 
    }
}
