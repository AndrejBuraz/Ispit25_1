using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burazerovic_Ispit_25_1_zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program koji će zatražiti od korisnika da unese dva stringa, te će ih ispisati po 
            abecedi u uzlaznom redoslijedu.*/
            string s1, s2;
            Console.WriteLine("Unesi prvi string: ");
            s1 = Console.ReadLine();
            Console.WriteLine("Unesi drugi string: ");
            s2 = Console.ReadLine();
            if(s1[0] < s2[0])
            {
                Console.WriteLine("Prvi string po abecedi: {0}\nDrugi string po abecedi: {1}", s1, s2);
            }
            else
            {
                Console.WriteLine("Prvi string po abecedi: {0}\nDrugi string po abecedi: {1}", s2, s1);
            }
            Console.ReadKey();
        }
    }
}
