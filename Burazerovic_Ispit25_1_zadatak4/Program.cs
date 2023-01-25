using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burazerovic_Ispit25_1_zadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program koji će za definirani niz tipa double pronaći član koji najmanje odstupa od 
            prosječne vrijednosti niza. Program mora raditi ispravno za proizvoljni broj članova niza.*/

            int n, i, brojNajmanjihOdstupanja = 0; 
            Console.WriteLine("Unesi broj članova niza:");
            n = Convert.ToInt32(Console.ReadLine());
            double[] niz = new double[n];
            double zbroj = 0, ar = 0, najmanjiOdstup = n;
            double najmanjeOdstupanje;
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Unesi " + (i + 1) + ". član niza: ");
                niz[i] = Convert.ToDouble(Console.ReadLine());
                zbroj += niz[i];
            }
            ar = zbroj / n;

            for(i = 0; i < n; i++)
            {
                if (niz[i] - ar < najmanjiOdstup && (niz[i] - najmanjiOdstup > 0)
                {
                    najmanjeOdstupanje = niz[i];
                    najmanjiOdstup = niz[i] - ar;
                    brojNajmanjihOdstupanja++;
                }
            }
            Console.WriteLine("Prosječna vrijednost niza je: {0}\nNajbliži član toj vrijednosti: {1}", ar, najmanjeOdstupanje);

            Console.ReadKey();

        }
    }
}
