using System;
namespace Generics
{
    class Animals
    {
        public string Name { get; set; }
        public Animals(string name="No name")
        {
            Name = name;
        }
        public static void getSum<T>(ref T num1,ref T num2)
        {
            double dblX = Convert.ToDouble(num1);
            double dblY = Convert.ToDouble(num2);
            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
        }
    }
}
