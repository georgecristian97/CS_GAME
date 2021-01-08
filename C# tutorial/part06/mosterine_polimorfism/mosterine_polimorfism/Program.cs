using System;

namespace mosterine_polimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "pisi",
                Sound = "miau"

            };
            Dog ctel = new Dog()
            {
                Name = "cutu",
                Sound = "woof"
            };
            ctel.MakeSoud();
            whiskers.makeSound();
            Console.WriteLine("Hello World!");

        }
    }
}
