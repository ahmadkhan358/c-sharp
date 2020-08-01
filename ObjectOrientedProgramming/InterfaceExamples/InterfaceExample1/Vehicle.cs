using System;
namespace Interfaces
{
    class Vehicle:IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }
        public Vehicle(string brand="No brand",int wheels=0,double speed = 0.0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"{Brand} is moving at {Speed} KPH");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} stops");
            Speed = 0.0;
        }
    }
}
