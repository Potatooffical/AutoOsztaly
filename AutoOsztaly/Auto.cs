using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOsztaly
{
    internal class Auto
    {
        public Auto(string marka, string tipus, int gyartasiEv, double megtettKilometer, int utolsoSzerviz)
        {
            Marka = marka;
            Tipus = tipus;
            GyartasiEv = gyartasiEv;
            MegtettKilometer = megtettKilometer;
            UtolsoSzerviz = utolsoSzerviz;
        }

        //márka(string), típus(string), gyártási év(int), megtett kilométer(int), utolsó szervíz(int)

        public string Marka
        {
            get; set;
        }

        public string Tipus
        {
            get; set;
        }

        public int GyartasiEv
        {
            get; set;
        }

        public double MegtettKilometer
        {
            get; set;
        }

        public int UtolsoSzerviz
        {
            get; set;
        }

        public void EletkorKiszamit()
        {
            int eletkor = DateTime.Now.Year - GyartasiEv;
            Console.WriteLine($"A {Marka} életkora: {eletkor}");
        }

        public void SzervizSzuksegesE()
        {
            if (MegtettKilometer - UtolsoSzerviz >= 20000)
                Console.WriteLine($"{Marka}: Szervíz szükséges!");
            else
                Console.WriteLine($"{Marka}: Nem szükséges szervíz!");
        }

        public void AdatKiir()
        {
            
            Console.WriteLine($"{Marka, -10}|{Tipus, -10}|{GyartasiEv, -11}|{MegtettKilometer, -17}|{UtolsoSzerviz, -14}");
            

        }

        public void Osszehasonlit(Auto auto) {
            
            if (auto.GyartasiEv < GyartasiEv)
                Console.WriteLine($"A {auto.Marka} az idősebb!");
            else
                Console.WriteLine($"A {Marka} az idősebb");

        }

    }
}
