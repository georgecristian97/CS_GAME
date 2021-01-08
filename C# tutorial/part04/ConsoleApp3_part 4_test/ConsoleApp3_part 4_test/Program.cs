using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp3_part_4_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double x = 5;
            double y = 4;
            Console.WriteLine("{0} + {1} = {2}",x,y,Suma(x,y));
            int sol;
            dubleaza(15,out sol);
            Console.WriteLine("15 * 2 = {0}", sol);
            int a = 1;
            int b = 2;
           
            Console.WriteLine("a = {0}   b = {1} \n dupa :", a,b);
            Swap(ref a, ref b);
            Console.WriteLine("a = {0}   b = {1}", a, b);
            Console.WriteLine(" 1 + 2 +..+ 7 = {0}", S_n(1, 2, 3,4,5,6,7));
            printI(zipCode: 15212, name: "AXL");
            Console.WriteLine("1 + 2 = {0}", Suma("1", "2"));

            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
            Console.ReadLine();
           
        }
        enum CarColor : byte
        {
            Orange = 1,
            Blue=2,
            Green,
            Yellow
        }
        static void PaintCar(CarColor cc)
            {
        Console.WriteLine("Masina este {0} cu codul {1}",cc, (int)cc);
            }
        static double Suma(double x = 1, double y=1)//pass by value le ia pe cele din main
        {
          /*  double temp = x;
            x = y;
            y = temp;
          */
            return x + y;
        }
        static double Suma(string x= "1", string y="1" )//pass by value le ia pe cele din main
        {
            /*  double temp = x;
              x = y;
              y = temp;
            */
            return Convert.ToDouble(x) + Convert.ToDouble(y);
        }
        static void dubleaza(int x, out int sol)
        {
            sol = x * 2;
        }

         static void Swap(ref int num1, ref int num2)//pass by ref se modif in fct
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static double S_n(params double[] num)
        {
            double s = 0;
            foreach(int i in num)
            {
                s = s + i;
            }
            return s;
        }

        static void printI(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the {1}", name, zipCode);
        }
    }
}
