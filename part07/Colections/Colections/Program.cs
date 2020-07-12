using System;
using System.Collections;

namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region ArrayList Code
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count: {0}",
                aList.Count);

            ArrayList aList2 = new ArrayList();

            aList2.AddRange(new object[] { "Mike",
            "Sally", "Egg"});

            aList.AddRange(aList2);

            aList2.Sort();
            aList2.Reverse();

            aList2.Insert(1,"Turkey");

            ArrayList range = aList2.GetRange(0, 2);

            foreach(object o in aList2)
            {
                Console.WriteLine(o);

            }
            Console.WriteLine("\n");
            foreach (object o in range)
            {
                Console.WriteLine(o);

            }
            #endregion
        }
    }
}
