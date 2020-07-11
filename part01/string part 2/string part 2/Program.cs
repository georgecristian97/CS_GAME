using System;

namespace string_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string randString = "This is a string";
            Console.WriteLine("A = a : {0}",
                string.Equals("A","a",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad left : {0}",
                randString.PadLeft(20, '.'));
            Console.WriteLine("Pad right : {0}",
                randString.PadRight(9, '.'));
            Console.WriteLine(("Hello World!").ToUpper());
            Console.WriteLine(("Hello World!").ToLower());

            Console.WriteLine(@"fix ce scriu la tastatura
()*&^%$ //././,..;']';'l\\]///\']/''

pana si saptiile liniile



3 linii see :D/'./';><}{"" dublu ghilimea sa apara 1 data 


sfagga
"" de la @");
        }
    }
}
