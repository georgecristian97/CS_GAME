using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(3+2);
            string a = "xt";
            string b = "tx";
            string c = a + b;
            Console.WriteLine(c);
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg {1} : {0}", i, args[i]);
                Console.WriteLine(i);
            }
            Console.WriteLine(c);
            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(String.Join(", ", myArgs));
            SayHello();
            Console.ReadLine();
            decimal decPiVal = 3.14M;
            decimal DecimalBigNum = 3.000000000000000000000011M;
            Console.WriteLine("Pi {0} + mult {1} = {2}", decPiVal, DecimalBigNum, decPiVal + DecimalBigNum);
            TimeSpan lunchtime = new TimeSpan( 4, 9, 30);
            lunchtime = lunchtime.Subtract(new TimeSpan(0, 15, 0));
            lunchtime = lunchtime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchtime.ToString());
            int P = 34;
            int f = P;
            float pp=P*f;
            P = (int)Math.Pow(P, 2);
            Console.WriteLine("P = {0} P^2={1} SAU  {2}", f, P, pp.ToString());
        }
        private static void SayHello()
        {
            string name;
            Console.Write("What is your full name: ");
            name = Console.ReadLine();
            if (name.Contains(" "))                {
                name = name.Remove(name.IndexOf(" "));
            }
        
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine("Max int : {0}", int.MaxValue);
            Console.WriteLine("Ming int : {0}", int.MinValue);
        }
    }
}
