using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burazerovic_Ispit25_1_zadatak5
{
    /*Definirajte klasu NebeskoTijelo sa sljedećim varijablama članicama:
            • varijable tipa double
            BrzinaOkoOsi 
            BrzinaOkoSunca 
            Definirajte klase Planet i Satelit izvedene iz klase NebeskoTijelo, te im definirajte sljedeće 
            konstruktore:
            Planet(double, double) 
            Satelit(double, double) 
            koji će dodijeliti vrijednosti proslijeđenih argumenata naslijeđenim varijablama članicama
            Definirajte dva objekta Zemlja i Mjesec tipova Planet i Satelit.*/

    class NebeskoTijelo
    {
        double BrzinaOkoOsi, BrzinaOkoSunca;

        public NebeskoTijelo()
        {
        }

        public NebeskoTijelo(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            this.BrzinaOkoOsi = brzinaOkoOsi;
            this.BrzinaOkoSunca = brzinaOkoSunca;
        }

        public double BrzinaOkoOsi1 { get => this.BrzinaOkoOsi; set => this.BrzinaOkoOsi = value; }
        public double BrzinaOkoSunca1 { get => this.BrzinaOkoSunca; set => this.BrzinaOkoSunca = value; }

        public override string ToString()
        {
            string ispis = ("Brzina oko osi: " + this.BrzinaOkoOsi + "\nBrzina oko Sunca: " + this.BrzinaOkoSunca);
            return ispis; ;
        }
    }

    class Planet : NebeskoTijelo
    {
        public Planet(double brzinaoOkoOsi, double brzinaOkoSunca) : base(brzinaoOkoOsi, brzinaOkoSunca)
        {

        }
    }
    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaoOkoOsi, double brzinaOkoSunca) : base(brzinaoOkoOsi, brzinaOkoSunca)
        {

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(5.5, 6.7);
            Satelit Mjesec = new Satelit(12.3, 23.1);
            Console.WriteLine("Zemlja: ");
            Console.WriteLine(Zemlja.ToString());
            Console.WriteLine("Mjesec: ");
            Console.WriteLine(Mjesec.ToString());
            Console.ReadKey();
            
        }
    }
}
