using System;
using System.Linq;

namespace inheritance_and_polymorphism
{
    class Mobiles
    {
        private string name;
        protected string model;
        public More_info mrin = new More_info();
        public void setMoreInfo(int mp,string owner)
        {
            mrin.MP = mp;
            mrin.Owner = owner;
        }
        public void getMoreInfo()
        {
            Console.WriteLine($"{Name} {Model} has {mrin.MP} mega pixels camera and it is owned by {mrin.Owner}");
        }
        public virtual void mblModel()
        {
            Console.WriteLine($"{Name} has a model number {Model}");
        }
        public Mobiles():this("No name","No model") { }
        public Mobiles(string name):this(name,"No model") { }
        public Mobiles(string name,string model)
        {
            Name = name;
            Model = model;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No name";
                }
                name = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > 8)
                {
                    model = "No model";
                    Console.WriteLine("Model must be less than 8 characters");
                }
                model = value;
            }            
        }
        public class batteryPerformance
        {
            public void CheckBattery(int hours)
            {
                if (hours >= 1 && hours <= 3)
                {
                    Console.WriteLine("Your battery performance is very bad");
                }
                else if (hours >= 4 && hours <= 6)
                {
                    Console.WriteLine("Your battery performance is bad");
                }
                else if (hours >= 7 && hours <= 9)
                {
                    Console.WriteLine("Your battery performance is good");
                }
                else if (hours >= 10 && hours <= 12)
                {
                    Console.WriteLine("Your battery performance is better");
                }
                else if (hours >= 13 && hours <= 15)
                {
                    Console.WriteLine("Your battery performance is exellent");
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}