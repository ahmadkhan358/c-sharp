using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_properties
{
    class Animals
    {
        private string name;
        private string sound;
        public const string shelter = "Ahmad's home for the shelter of animals";
        public readonly int idNum;
        public void makeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        public Animals():this("No name","No sound") { }
        public Animals(string name):this(name,"No sound") { }
        public Animals(string name,string sound)
        {
            setName(name);
            Sound = sound;
            NumOfAnimals = 1;
            Random rnd = new Random();
            idNum = rnd.Next(1, 123456789);
        }
        public void setName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No name";
                Console.WriteLine("Name can't contain digits");
            }
        }
        public string getName()
        {
            return name;
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if(value.Length>10)
                {
                    sound = "No sound";
                    Console.WriteLine("This sound is too long");
                }
                sound = value;
            }
        }
        public string owner { get; set; } = "No owner";
        public static int numOfAnimals = 0;
        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }

    }
}
