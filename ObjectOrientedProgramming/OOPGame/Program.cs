using System;

namespace OOP_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior Harry = new Warrior("Harry", 1000, 120, 40);
            Warrior Voldemort = new Warrior("Voldemort", 1000, 120, 40);
            Battle.StartFight(Harry, Voldemort);
            Console.ReadKey();
        }
    }
}