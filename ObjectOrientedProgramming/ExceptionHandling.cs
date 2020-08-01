using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 0;
            try
            {
                Console.WriteLine("Division : {0}",division(num1, num2));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You cant divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("You cant divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaning up");
            }
            Console.ReadKey();
        }
        private static double division(double x,double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
    }
}
