using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOsztaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var skoda = new Auto("Skoda", "Fabia", 2004, 250000, 10000);
            var volvo = new Auto("Volvo", "V-70", 2005, 30000, 20000);

            Console.WriteLine("Márka     |Típus     |Gyártási év|Megtett kilométer|Utolsó szervíz|");

            skoda.AdatKiir();
            volvo.AdatKiir();

            skoda.EletkorKiszamit();
            volvo.EletkorKiszamit();

            skoda.SzervizSzuksegesE();
            volvo.SzervizSzuksegesE();

            skoda.Osszehasonlit(volvo); //:D

            Console.ReadKey();
        }
    }
}
