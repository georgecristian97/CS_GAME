using System;
using System.IO;
using System.Net.Mime;

namespace ConsoleApp3_cond_while_excep
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 17;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("du-te la gradi");

            }
            else if ((age > 7) && (age <= 14))
            {
                Console.WriteLine("du-te la primara apoi gimnaziu");
            }
            else if (age < 19)
            {
                Console.WriteLine("du-te la liceu");
            }
            else { 
                Console.WriteLine("du- te la facultate");
            }

            bool potCond = age >= 16 ? true : false;
            
            switch(age)
            {
                case 1:
                case 2:
                    Console.WriteLine("G T D C");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("G T Pr");
                    break;
                case 5:
                     Console.WriteLine("G T K");
                    goto end;
            }

        end:
            Console.WriteLine("E M H S");

            string name = "Derek";
            string name2 = "Derek";

            if (name.Equals(name2,StringComparison.Ordinal))
            {
                Console.WriteLine("Name  {0} and {1} are Equal.",name,name2);
            }
            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                   
                    continue;
                }
                Console.WriteLine("{0}", i);
                i++;

            }

            Random rNr = new Random();
            int sNr = rNr.Next(1, 11);
            int nrG = 0;

            do
            {
                Console.WriteLine("Nr intre 1 si 10 ");
                nrG = Convert.ToInt32(Console.ReadLine());

            } while (sNr != nrG);

           
            double num1 = 5;
            double num2 = 0;
            try
            {
                Console.WriteLine("5/0 = {0}",
                    DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Nu mere cu 0");

                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine("Eroare");

                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Cleaning up");
            }
            Console.ReadLine();
        }
        static double DoDivision(double x, double y)
        {
            if (y == 0) ;
            {
                throw new System.DivideByZeroException();

            }
            return x / y;
        }
    }
}
