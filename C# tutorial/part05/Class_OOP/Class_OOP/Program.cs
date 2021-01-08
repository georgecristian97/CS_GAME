using System;
using System.Drawing;

namespace Class_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Patrat P1;
            P1.length = 200;
            P1.width = 50;
            Console.WriteLine("Patratul P1 cu L = {0} si l = {1} are Aria = {2}",P1.length,P1.width,P1.Arie());
            Patrat P2 = new Patrat(100, 40);
            Console.WriteLine("Patratul P2 cu L = {0} si l = {1} are Aria - {2}",P2.length,P2.width,P2.Arie());
            Console.ReadLine();

        }

        struct Patrat
        {
            public double length;
            public double width;

            public Patrat(double L = 1, double w = 1)
            {
                length = L;
                width = w;
            }

            public double Arie()
            {
                return length * width;
            }

        }
    }
}
