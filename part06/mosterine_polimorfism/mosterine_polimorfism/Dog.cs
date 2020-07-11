using System;
using System.Collections.Generic;
using System.Text;

namespace mosterine_polimorfism
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrrr";


        public new void MakeSoud()
        {
            Console.WriteLine($"{Name} say {Sound} and {Sound2}");

        }
        public Dog(string name = "No Name",string sound = "No Sound",
            string  sound2 = "grrr")
        :base(name, sound)
        {
            Sound2 = sound2;
        }
    }
}
