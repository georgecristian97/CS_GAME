using System;

namespace constructor_propr
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal x = new Animal();
            x.xt3 = "ms";
            x.facesunet();
            
            Animal.Sumat3(x);
            Animal.Sumat2(x);
            Animal.Sumat1(x);
            Console.WriteLine("{0}",x.idn);
            Console.WriteLine("{0}", x.constr(x));
            Console.WriteLine("Hello World!");
        }

    }
}
