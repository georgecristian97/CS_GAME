using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigNum = BigInteger.Parse("12341252151543615115");
            Console.WriteLine("BIG nr = {0}", bigNum * 2);

            Console.WriteLine("Pret : {0:c}", 23, 555);
            Console.WriteLine("Pad with 0s :{0:d4}", 23);
            Console.WriteLine("3 zecimale : {0:3f}", 23.445);
            Console.WriteLine("Commas : {0:n4}", 2300);
            Console.WriteLine("Hello World!");

            string str = "asta e sir de caractere";
            Console.WriteLine("lungime str = {0}", str.Length);
            string afir;
            afir = "Fals";
            if (str.Contains("e"))
            {
                afir = "Adev";
            }
            Console.WriteLine("afirmatia : sirul contine 'e' este {0} ",
                afir);
            Console.WriteLine("prima pozitie pe care il gasim pe e este {0}",
                str.IndexOf("e"));
            Console.WriteLine("Sterge primele 6 de la pozitia 0 : {0}",
                str.Remove(0, 6));
            Console.WriteLine("inseram pe pozitia 10 BMW : ",
                str.Insert(10, "BMW"));
            Console.WriteLine("Inlocuim toate aparitiile 'e' cu rxtxr {0} : ",
                str.Replace("e", "rxtxr"));
            Console.WriteLine("Compara A cu B : {0}", 
                String.Compare("A","B", StringComparison.OrdinalIgnoreCase));
        }
    }
}
