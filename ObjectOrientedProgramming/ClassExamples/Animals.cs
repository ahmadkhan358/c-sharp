using System;

namespace classes_and_oop_aproaches
{
    class Animals
    {
        public string name;
        public string sound;
        public Animals()
        {
            name = "no name";
            sound = "no sound";
            count++;
        }
        public void makeSound()
        {
            Console.WriteLine("The {0} says {1}", name, sound);
        }
        public static int count = 0;
        public static void getCount()
        {
            Console.WriteLine("Number of animals = {0}", count);
        }
    }
}
