using System;
using System.Collections.Generic;
using System.Text;

namespace interfete
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("Tv off");
        }

        public void On()
        {
            Console.WriteLine("Tv on");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            
                Console.WriteLine($"Tv Volume is at {Volume}");
            
          
           }

        public void VolumeUp()
        {
            if (Volume < 100) Volume++;

            Console.WriteLine($"Tv Volume is at {Volume}");

        }
    }
}
