using System;

namespace oop_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            animal fox = new animal()
            {
                name = "Red_fox",
                sound = "Raaw"
            };
            Console.WriteLine("{0} face {1}\n {0} este animalul #{2}", fox.name, fox.sound, animal.NrA());
            Console.ReadLine();
        }
    }
}
