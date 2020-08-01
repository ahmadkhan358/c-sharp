using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals();
            cat.setName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("Cat is named {0} and says {1}", cat.getName(), cat.Sound);
            cat.owner = "Ahmad";
            Console.WriteLine("{0} owner is {1}", cat.getName(), cat.owner);
            Console.WriteLine("{0} shelter id is {1}", cat.getName(), cat.idNum);
            Console.WriteLine("Number of animals : {0}", Animals.NumOfAnimals);
            Console.ReadKey();
        }
    }
}
