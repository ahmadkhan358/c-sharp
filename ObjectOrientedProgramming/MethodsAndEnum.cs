using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_and_enum
{
    class Program
    {
        public static int count = 1;
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 10;
            int num3;
            int num4 = 15, num5 = 20;
            Console.WriteLine("Sum of numbers = {0}", funcSum(num1, num2));
            doubleIt(15, out num3);
            Console.WriteLine("Double of 15 = {0}", num3);
            Console.WriteLine("Before swaping num4 = {0} num5 = {1}", num4, num5);
            swap(ref num4, ref num5);
            Console.WriteLine("After swaping num4 = {0} num5 = {1}", num4, num5);
            Console.WriteLine("1+2+3+4+5 = {0}", getSum(1, 2, 3, 4, 5));
            CarColor car1 = CarColor.Red;
            CarColor car2 = CarColor.Green;
            CarColor car3 = CarColor.Blue;
            CarColor car4 = CarColor.Yellow;
            CarColor car5 = CarColor.White;
            CarColor car6 = CarColor.Black;
            paintCar(car1);
            paintCar(car2);
            paintCar(car3);
            paintCar(car4);
            paintCar(car5);
            paintCar(car6);
            Console.WriteLine("Difference of numbers = {0}", difference(999, 876));
            Console.WriteLine("Difference of numbers = {0}", difference("999", "876"));
            Console.ReadKey();
        }
        static double funcSum(double x, double y)
        {
            return x + y;
        }
        static void doubleIt(int x,out int num3)
        {
            num3 = x * 2;
        }
        public static void swap(ref int num4, ref int num5)
        {
            int temp = num4;
            num4 = num5;
            num5 = temp;
        }
        public static int getSum(params int[] numbers)
        {
            int sum = 0;
            int count = numbers.Length;
           //Console.WriteLine("Length of array : {0}", count);
            for(int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        enum CarColor : byte
        {
            Red=1,
            Green,
            Blue,
            Yellow,
            White,
            Black
        }
        static void paintCar(CarColor cc)
        { 
            Console.WriteLine("Car{0} is painted {1} with the color code {2}", count, cc, (int)cc);
            count++;
        }
        static double difference(double x,double y)
        {
            return x - y;
        }
        static double difference(string x,string y)
        {
            double dblx = Convert.ToDouble(x);
            double dbly = Convert.ToDouble(y);
            return dblx - dbly;
        }
    }
}