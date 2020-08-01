using System;
using System.Collections.Generic;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animals> animalsList = new List<Animals>();
            animalsList.Add(new Animals() { Name = "Dog" });
            animalsList.Add(new Animals() { Name = "Cat" });
            animalsList.Add(new Animals() { Name = "Horse" });
            animalsList.Insert(1, new Animals() { Name = "Lion" });
            Console.WriteLine("Number of animals : {0}", animalsList.Count);
            foreach (Animals a in animalsList)
            {
                Console.WriteLine(a.Name);
            }
            int x = 99, y = 100;
            Animals.getSum(ref x, ref y);
            string strx = "99", stry = "100";
            Animals.getSum(ref strx, ref stry);
            Rectangle<int> rect1 = new Rectangle<int>(10, 5);
            Console.WriteLine(rect1.getArea());
            Rectangle<string> rect2 = new Rectangle<string>("10", "5");
            Console.WriteLine(rect2.getArea());
            Arithematic add, sub, addSub;
            add = new Arithematic(Add);
            sub = new Arithematic(Subtract);
            addSub = add + sub;
            Console.WriteLine("Add 10 and 6");
            Add(10, 6);
            Console.WriteLine("Add and Subtract 10 and 4");
            addSub(10, 4);
            Console.ReadKey();
        }
        public struct Rectangle<T>
        {
            private T length;
            private T width;
            public T Length
            {
                get { return length; }
                set { length = value; }
            }
            public T Width
            {
                get { return width; }
                set { width = value; }
            }
            public Rectangle(T l, T w)
            {
                length = l;
                width = w;
            }
            public string getArea()
            {
                double dblLength = Convert.ToDouble(Length);
                double dblWidth = Convert.ToDouble(Width);
                return string.Format($"{Length} * {Width} = {dblLength * dblWidth}");
            }
        }
        public delegate void Arithematic(double num1, double num2);
        public static void Add(double num1,double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}