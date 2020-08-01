using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq_extension
{
    class Program
    {
        delegate double doubleIt(double val);
        static void Main(string[] args)
        {
            doubleIt dblit = x => x * 2;
            Console.WriteLine($"5*2 = {dblit(5)}");
            List<int> numbList = new List<int> { 1, 3, 5, 6, 7, 9, 2 };
            var evenList = numbList.Where(a => a % 2 == 0).ToList();
            var rangeList = numbList.Where(r => (r > 2) && (r < 9)).ToList();
            foreach(var v in rangeList)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
