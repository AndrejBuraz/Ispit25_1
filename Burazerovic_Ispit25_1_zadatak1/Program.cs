using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burazerovic_Ispit25_1_zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        { /*Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova te će svaki razmak zamijeniti znakom '_'.*/

            Console.WriteLine("Unesi niz znakova: ");
            string unos = Console.ReadLine();
            Console.WriteLine("String znakova u kojem su razmaci zamijenjeni doljnom crtom je: " + unos.Replace(' ', '_'));
            Console.ReadKey();
        }
    }
}
