using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class Box
    {
        private int Length;
        private int Width;
        private int Breadth;
        public Box() : this(1, 1, 1) { }
        public Box(int l,int w,int b)
        {
            Length = l;
            Width = w;
            Breadth = b;
        }
        public static Box operator +(Box box1, Box box2)
        {
            Box myBox = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return myBox;
        }
        public static Box operator -(Box box1, Box box2)
        {
            Box myBox = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return myBox;
        }
        public void display()
        {
            Console.WriteLine("Length of box : {0}, Width of box : {1}, Breadth of box : {2}", Length, Width, Breadth);
        }
    }
}
