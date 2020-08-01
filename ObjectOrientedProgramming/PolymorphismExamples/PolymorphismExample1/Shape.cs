using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Shape
    {
        public string Name { get; set; }
        public virtual void getInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
        public abstract double area();
    }
}
