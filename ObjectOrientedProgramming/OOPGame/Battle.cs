using System;

namespace OOP_game
{
    class Battle
    {
        //StartFight
        //Warrior1 ,Warrior2
        public static void StartFight(Warrior warrior1,Warrior warrior2)
        {
            //Loop giving chance to each warrior to attack and block each term until one dies
            while (true)
            {
                if (GetAttackResults(warrior1, warrior2) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
                if (GetAttackResults(warrior2, warrior1) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
            }
        }

        //GetAttackResults
        //WarriorA, WarriorB
        public static string GetAttackResults(Warrior warriorA,Warrior warriorB)
        {
            double warAAttkAmt = warriorA.Attack();
            double warBBlockAmt = warriorB.Block();

            //Calculate one warrior's attack and other's block
            //Subtract block from attack
            double dmg2WarB = warAAttkAmt - warBBlockAmt;

            //If there is damage then subtract that form the health of other one
            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else
            {
                dmg2WarB = 0;
            }

            //Print out info about who attacked who and how much damage
            Console.WriteLine("{0} attacked {1} and deals {2} damage", warriorA.Name, warriorB.Name, dmg2WarB);

            //Output on the change in health
            Console.WriteLine("{0} has {1} health \n", warriorB.Name, warriorB.Health);

            /*Check if the warrior's health fells below zero 
             * then print a message and send a response that will end the loop*/
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorius \n", warriorB.Name, warriorA.Name);
                return "Game over";
            }
            else
            {
                return "Fight again";
            }
        }
    }
}