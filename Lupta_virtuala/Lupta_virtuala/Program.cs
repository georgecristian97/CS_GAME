using System;

namespace Lupta_virtuala
{
    class Program
    {
        static void Main(string[] args)
        {
            luptator a = new luptator();
            a.nume = "ninja";
            a.arma = "dagger";
            a.hp = 16000;
            a.dmg = 2500*2;
            a.crit = 160;
            a.def = 700;
            luptator b = new luptator();
            b.nume = "razboinic";
            b.arma = "sabie";
            b.dmg = 4500;
            b.def = 800;
            b.crit = 120;
            b.hp = 18000;
            batalie x = new batalie();

            x.lupta(a, b);

            //Console.WriteLine("Hello World!");
        }
    }
}
