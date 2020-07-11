using System;
using System.Collections.Generic;
using System.Linq;

// Needed for StringBuilder
using System.Text;
using System.Threading.Tasks;

// For culture specific formating
using System.Globalization;


namespace ConsoleApp3part2_complet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] favNums = new int[3];
            favNums[0] = 22;
            Console.WriteLine("favNums [0] = {0} ", favNums[0]);
            string[] constumer = { "Bo", "Sa", "Su" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.24 };
            Console.WriteLine("Array {0} : Value: {1}", randomArray[2].GetType(), favNums[0]);
            randomArray[2].GetType();

            string[,] cN = new string[2, 2] { { "B", "Sm" }, { "Sa", "Ma" } };
            Console.WriteLine("MD Value : {0}   ", cN.GetValue(1, 1));
            for (int i = 0; i < cN.GetLength(0); i++)
            {       for (int j = 0; j < cN.GetLength(1); j++)

                {
                    Console.Write("v[{0}][{1}] : {2}  ", i,j,cN.GetValue(i, j));
                }
                Console.Write("\n");
            }
            int[] nr = { 1, 2, 3, 4, 5 };
            int ti;
                ti = 0;
            foreach (int k in nr)
            {
                                 
                Console.WriteLine("Pt {0} : {1}",ti,k);
                ti++;
            }

            int[] nr1 = { 1, 11, 111 };
            foreach(int x in nr1)
            {
                Console.WriteLine("{0} > 10 : {1} ",x, GT10(x));
            }
            //Console.ReadLine();

            string str = "";
            str = str + "11-" + "22-" + "2020";
            Console.WriteLine("str = {0}", str);

            // Create a StringBuilder with a default size
            // of 16 characters, but it grows automatically
            StringBuilder sb = new StringBuilder("Random Text");

            // Create a StringBuilder with a size of 256
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);

            // Get max size
            Console.WriteLine("Capacity : {0}", sb2.Capacity);

            // Get length
            Console.WriteLine("Length : {0}", sb2.Length);

            sb2.AppendLine("\nMore important");
            CultureInfo enUS =
                CultureInfo.CreateSpecificCulture("en-us");
            string bestCust = "bob Smith";
            sb2.Append("Random Text");
            Console.WriteLine(sb.Equals("Random"));
            int a = 1024;
            float b = 1024;
            double c = 1024;
            short d = 1024;
            Console.WriteLine("{0} {1} {2} {3} ", System.Runtime.InteropServices.Marshal.SizeOf(a), System.Runtime.InteropServices.Marshal.SizeOf(b), System.Runtime.InteropServices.Marshal.SizeOf(c), System.Runtime.InteropServices.Marshal.SizeOf(d));
        }
       private static bool GT10(int val)
        {
            return val > 10;
        }

    }
}
