using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(4,5,6);
            Box box2 = new Box(7,8,9);
            Box box3 = box2 - box1;
            box3.display();
            Console.ReadKey();
        }
    }
}
