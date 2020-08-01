using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }
        public override double area()
        {
            return Math.PI * (Math.Pow(Radius, 2.0)); 
        }
        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine($"It has a radius of {Radius}");
        }
    }
}
