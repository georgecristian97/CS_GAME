using System;

namespace abstract__
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };
            foreach(Shape s in shapes)
                    {
                s.GetInfo();
                Console.WriteLine("{0}  Area : {1:f2}",s.Name,s.Area());
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("Nu e cerc");

                }
                if (s is Circle)
                {
                    Console.WriteLine("Nu e dreptunghi");
                }
                object circ1 = new Circle(4);
                Circle circ2 = (Circle)circ1;
                Console.WriteLine("The {0} Area is {1:f2}",
                    circ2.Name, circ2.Area());


            }

            Console.ReadLine();
    }
}
    
}
