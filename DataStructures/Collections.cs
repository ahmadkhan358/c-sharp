using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#region arrayList code
             ArrayList aList = new ArrayList();
             aList.Add("Ahmad");
             aList.Add(20);
             aList.Add(90.55);
             Console.WriteLine("Count : {0}", aList.Count);
             Console.WriteLine("Capacity : {0}", aList.Capacity);
             ArrayList aList2 = new ArrayList();
             aList2.AddRange(new object[] { "Ahmad", "Eman", "Aqib", "Khadija" });
             aList.AddRange(aList2);
             aList2.Sort();
             aList2.Reverse();
             aList.Insert(1, "Amjad");
             ArrayList Range = aList2.GetRange(0, 2);
             foreach(object o in Range)
             {
                 Console.WriteLine(o);
             }
             Console.WriteLine("The index of Amjad : {0}", aList2.IndexOf("Amjad", 0));
             string[] myArray = (string[])aList2.ToArray(typeof(string));
             string[] Customers = { "Harry", "Hermoine", "Ronald" };
             ArrayList custArrayList = new ArrayList();
             custArrayList.AddRange(Customers);
             foreach(string custobj in custArrayList)
             {
                 Console.WriteLine(custobj);
             }
             #endregion*/

            /*#region Dictionary code
            Dictionary<string, string> superHeros = new Dictionary<string, string>();
            superHeros.Add("Tony Stark", "Iron Man");
            superHeros.Add("Steve Rogers", "Captain America");
            superHeros.Add("Bruce Banner", "Hulk");
            Console.WriteLine("Count : {0}", superHeros.Count);
            Console.WriteLine("Tony Stark : {0}", superHeros.ContainsKey("Tony Stark"));
            superHeros.TryGetValue("Tony Stark", out string name);
            Console.WriteLine($"Tony Stark : {name}");
            foreach(KeyValuePair<string,string> item in superHeros)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            #endregion*/

            #region Queue code
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            foreach(object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }
            #endregion

            #region Stack code
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            foreach (object p in stack)
            {
                Console.WriteLine($"Stack : {p}");
            }
            #endregion


            string x = "a";

            int sum = 0;
            foreach (char ch in x)
            {
                int c = (int)ch;
                sum += c;
            }

            //sum *= 9;

            sum %= 50;

            Console.WriteLine(sum);



            Console.ReadKey();
        }
    }
}
