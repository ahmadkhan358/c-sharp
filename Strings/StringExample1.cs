using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHello("Ahmad");
            //stringTraversal("This is a string");
            stringPadding("Believe in yourself");
            Console.ReadKey();
        }
        private static void sayHello(string name)
        {
            /*Console.Write("What is your name ? ");
            name = Console.ReadLine();*/
            Console.WriteLine("Hello {0}", name);
        }
        static void stringTraversal(string newString)
        {
            Console.WriteLine("Length of the String is : {0}", newString.Length);
            Console.WriteLine("String contains word \'is\' : {0}", newString.Contains("is"));
            Console.WriteLine("Index is word \'is\' : {0}", newString.IndexOf("is"));
            Console.WriteLine("Remove characters : {0}", newString.Remove(0, 7));
            Console.WriteLine("Insert characters : {0}", newString.Insert(10, "short "));
            Console.WriteLine("Replace characters : {0}", newString.Replace("string", "sentence"));
            Console.WriteLine("Compare two string {0}",
                String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
        }
        static void stringPadding(string passAstring)
        {
            Console.WriteLine("Left padding : {0}", passAstring.PadLeft(20, '.'));
            Console.WriteLine("Right padding : {0}", passAstring.PadRight(20, '.'));
            Console.WriteLine("Trim the string : {0}", passAstring.Trim());
            Console.WriteLine("Upper case string : {0}", passAstring.ToUpper());
            Console.WriteLine("Lower case string : {0}", passAstring.ToLower());
            string newStr = String.Format("{0} khan is a {1} and {2} {3}", "Ahmad", "Bright", "Brilliant", "student");
            Console.WriteLine("{0}", newStr);
            Console.Write(@"Exactly what I typed \'");
        }
    }
}
