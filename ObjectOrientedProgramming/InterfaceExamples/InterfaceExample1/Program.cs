using System;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle BMW = new Vehicle("BMW", 4, 160);
            if(BMW is IDrivable)
            {
                BMW.Move();
                BMW.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", BMW.Brand);
            }
            Console.ReadKey();
        }
    }
}
