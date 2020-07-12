using System;
using System.Collections.Generic;

namespace dictionare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<string, string> superheroes
                = new Dictionary<string, string>();
            superheroes.Add("Clark Kent",
                "Superman");
            superheroes.Add("Bruce Wayne",
                "Batman");
            superheroes.Add("Barry West",
                "Flash");
            superheroes.Remove("Barry West");

            Console.WriteLine($"Count : " +
                $"{superheroes.Count}");
            Console.WriteLine($"Clark Kent : " +
                $"{superheroes.ContainsKey("Clark Kent")}");
            superheroes.TryGetValue("Clark Kent",
              out string test);
            Console.WriteLine($"Clark Kent : {test}");

            foreach(KeyValuePair<string, string> item in
                superheroes)
            {
                Console.WriteLine("{0} : {1}",
                    item.Key,
                    item.Value);

            }

            superheroes.Clear();

            //foreach (s<a> in superheroes)
            //{ Console.WriteLine($"{s} {x}"); }
        }
    }
}
