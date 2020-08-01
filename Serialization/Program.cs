using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal("Whiskers", 20, 13);
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, whiskers);
            stream.Close();
            whiskers = null;
            stream = File.Open("AnimalData.dat", FileMode.Open);
            bf = new BinaryFormatter();
            whiskers = (Animal)bf.Deserialize(stream);
            stream.Close();
            Console.WriteLine(whiskers.ToString());
            Console.ReadKey();
        }
    }
}
