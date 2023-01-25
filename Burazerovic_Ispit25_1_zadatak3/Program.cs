using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burazerovic_Ispit25_1_zadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fibonaccijev niz definiran je na sljedeći način: 
            • prvi član niza je 0 
            • drugi član niza je 1 
            • svaki sljedeći član niza jednak je zbroju prethodna dva člana 
            Napišite program koji će zatražiti od korisnika da unese broj n, te će izračunati n-ti član 
            Fibonaccijevog niza.*/
            int n, x = 0;
            Console.WriteLine("Unesi broj: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                x += i;
            }
            Console.WriteLine(n + "-ti član Fibonaccijevog niza je: " + x);
            Console.ReadKey();
        }
    }
}
