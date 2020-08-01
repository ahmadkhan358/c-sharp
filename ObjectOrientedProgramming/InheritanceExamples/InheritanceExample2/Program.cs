using System;

namespace classes_and_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            VPtutorial vpt = new VPtutorial();

            vpt.renameTutorial(".NET tutorial");

            Console.WriteLine(vpt.getRenameTutorial());

            Console.ReadKey();
        }
    }
}
