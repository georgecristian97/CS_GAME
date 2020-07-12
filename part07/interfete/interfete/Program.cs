using System;

namespace interfete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Vehicle buick = new Vehicle("Buick", 4, 160);
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();

            }
            else {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }

            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powB = new PowerButton(TV);
            powB.Execute();
            powB.Undo();

            Console.ReadLine();
        }
    }
}
