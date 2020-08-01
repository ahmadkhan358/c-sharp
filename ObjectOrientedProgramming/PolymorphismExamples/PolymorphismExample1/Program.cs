using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(3), new Rectangle(4, 5) };
            foreach(Shape s in shapes)
            {
                s.getInfo();
                Console.WriteLine("{0} has an area : {1:f2}", s.Name, s.area());
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("It isn't a circle");
                }
                if(s is Circle)
                {
                    Console.WriteLine("It isn't a rectangle");
                }
                Console.WriteLine();
                object circ1 = new Circle(4);
                Circle circ2 = (Circle)circ1;
                Console.WriteLine("The {0} area is : {1:f2}", circ2.Name, circ2.area());
            }
            Console.ReadKey();
        }
    }
}
