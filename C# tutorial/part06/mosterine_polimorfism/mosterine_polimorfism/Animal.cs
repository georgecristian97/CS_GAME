using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Text;

namespace mosterine_polimorfism
{
    class Animal
    {
        private string name;
        private string sound;

        public void makeSound()
            {
            Console.WriteLine($" { Name} says { Sound} ");
            

            }
        public Animal()
        :this ("No Name ", "No Sound"){}
        public Animal(string name)
            : this(name, "Nop sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
            
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
           
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length> 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }

        }


    }
}
