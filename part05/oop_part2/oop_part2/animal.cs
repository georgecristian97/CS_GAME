using System;
using System.Collections.Generic;
using System.Text;

namespace oop_part2
{
    class animal
    {
        public string name;
        public string sound;

        public animal()
        {
            name = "No name";
            sound = "No sound";
            nrA++;
        }

        public animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No sound";
            nrA++;
        }
        public animal(string name = "No Name",string sound= "No Sound")
        {
            this.name = name;
            this.sound = sound;
            nrA++;
        }
        public void MakeSound()
        {
            Console.WriteLine("{0} zice {1}",name,sound);
        }

        static int nrA = 0;
        public static int NrA()
        {
            return nrA;
        }
    }
}
