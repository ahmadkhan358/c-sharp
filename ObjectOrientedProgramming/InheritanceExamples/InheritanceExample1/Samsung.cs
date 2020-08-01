using System;

namespace inheritance_and_polymorphism
{
    class Samsung : Mobiles
    {
        public string Galaxy { get; set; } = "Galaxy S7 Edge";
        public override void mblModel()
        {
            Console.WriteLine($"{Name} {Galaxy} has a model number {Model}");
        }
        public Samsung(string name="No name",string galaxy="No galaxy",string model="No model")
            : base(name, model)
        {
            Galaxy = galaxy;
        }
    }
}
