using System;
using System.Collections.Generic;
using System.Text;

namespace abstract__
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a radius of {Radius}");
            
        }
       

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }
    }
}
