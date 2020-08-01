using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Rectangle:Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length,double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }
        public override double area()
        {
            return Length * Width;
        }
        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine($"It has a length of {Length} and width of {Width}");
        }
    }
}
