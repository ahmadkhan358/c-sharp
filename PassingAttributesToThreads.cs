using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Passing_attributes_to_threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() => CountTo(10));
            t.Start();
            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();
            Console.ReadKey();
        }
        static void CountTo(int maxnum)
        {
            for(int i = 0; i < maxnum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
