using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("My name is Ahmad Khan");
            StringBuilder sb2 = new StringBuilder("My father name is Amjad Khan", 256);
            Console.WriteLine("Capacity of first string : {0}", sb.Capacity);
            Console.WriteLine("Capacity of second string : {0}", sb2.Capacity);
            Console.ReadKey();
        }
    }
}
