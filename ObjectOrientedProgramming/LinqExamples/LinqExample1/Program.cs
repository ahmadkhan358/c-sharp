using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();
            QueryIntArray();
            QueryArrayList();
            QueryArrayCollection();
            QueryAnimalData();
            Console.ReadKey();
        }
        static void QueryStringArray()
        {
            string[] dogs = { "German Shephard", "Belgium Shephard", "Bull Dog",
                "Panther", "Pointer", "Labra Dog",
                "Husky", "Wolf Dog", "Assassian" };
            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;
            foreach(var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var num20 = from num in nums
                        where num > 20
                        orderby num
                        select num;
            foreach(var i in num20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine($"Get type : {num20.GetType()}");
            var numList = num20.ToList<int>();
            var numArray = num20.ToArray();
            Console.WriteLine();
            return numArray;
        }
        static void QueryArrayList()
        {
            ArrayList FarmAnimals = new ArrayList()
            {
                new Animal
                {
                    Name ="Sheep",
                    Weight =1.3,
                    Height =19
                },
                new Animal
                {
                    Name ="Buffalo",
                    Weight =6.8,
                    Height =36
                },
                new Animal
                {
                    Name ="Cow",
                    Weight =6.5,
                    Height =32
                }
            };
            var animalEnum = FarmAnimals.OfType<Animal>();
            var bigAnimals = from ani in animalEnum
                             where ani.Weight > 6.0
                             orderby ani.Name
                             select ani;
            foreach(var animal in bigAnimals)
            {
                Console.WriteLine("{0} weighs {1} lbs", animal.Name, animal.Weight);
            }
            Console.WriteLine();
        }
        static void QueryArrayCollection()
        {
            var DogList = new List<Animal>()
            {
                new Animal
                {
                    Name="German Shephard",
                    Weight=40,
                    Height=17
                },
                new Animal
                {
                    Name="Belgium Shephard",
                    Weight=46,
                    Height=16
                },
                new Animal
                {
                    Name="Pointer",
                    Weight=30,
                    Height=20
                }
            };
            var bigDogs = from bd in DogList
                          where (bd.Weight > 30) && (bd.Height > 15)
                          orderby bd.Name
                          select bd;
            foreach(var k in bigDogs)
            {
                Console.WriteLine("A {0} weighs {1} lbs", k.Name, k.Weight);
            }
            Console.WriteLine();
        }
        static void QueryAnimalData()
        {
            Animal[] animals = new[]
            {
                new Animal
                {
                    Name="German Shephard",
                    Height=27,
                    Weight=80,
                    AnimalID=1
                },
                new Animal
                {
                    Name="Belgium Shephard",
                    Height=25,
                    Weight=88,
                    AnimalID=2
                },
                new Animal
                {
                    Name="Pointer",
                    Height=36,
                    Weight=50,
                    AnimalID=3
                },
                new Animal
                {
                    Name="Bull dog",
                    Height=18,
                    Weight=60,
                    AnimalID=4
                }
            };
            Owner[] owners = new[]
            {
                new Owner
                {
                    Name="Ahmad Khan",
                    OwnerID=1
                },
                new Owner
                {
                    Name="Umer Khan",
                    OwnerID=2
                },
                new Owner
                {
                    Name="Basit Khan",
                    OwnerID=3
                },
                new Owner
                {
                    Name="Yousaf Khan",
                    OwnerID=4
                }
            };
            var innerJoin = from animal in animals
                            join owner in owners on animal.AnimalID
                            equals owner.OwnerID
                            select new
                            {
                                OwnerName = owner.Name,
                                AnimalName = animal.Name
                            };
            foreach(var i in innerJoin)
            {
                Console.WriteLine("{0} owns {1}", i.OwnerName, i.AnimalName);
            }
            Console.WriteLine();
            var groupJoin = from owner in owners
                            orderby owner.OwnerID
                            join animal in animals
                            on owner.OwnerID
                            equals animal.AnimalID
                            into ownerGroup
                            select new
                            {
                                Owner = owner.Name,
                                Animals = from owner2
                                          in ownerGroup
                                          orderby owner2.Name
                                          select owner2
                            };
            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animals)
                {
                    Console.WriteLine("* {0}", animal.Name);
                }
            }
        }
    }
}
