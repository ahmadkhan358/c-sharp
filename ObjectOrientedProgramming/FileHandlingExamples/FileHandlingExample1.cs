using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace File_Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo data = new DirectoryInfo(@"C:\Users\akhn3\source\repos\File Streams\File Streams");
            string[] family = { "Ahmad", "Eman", "Aqib", "Khadija" };
            string textFilePath = @"C:\Users\akhn3\source\repos\File Streams\File Streams\File.txt";
            File.WriteAllLines(textFilePath, family);
            foreach(string fam in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Siblings : {fam}");
            }
            DirectoryInfo SearchFile = new DirectoryInfo(@"C:\Users\akhn3\source\repos\File Streams\File Streams");
            FileInfo[] textFile = SearchFile.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Matches : {0}", textFile.Length);
            foreach(FileInfo file in textFile)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }
            string textFilePath2 = @"C:\Users\akhn3\source\repos\File Streams\File Streams\File2.txt";
            FileStream fs = File.Open(textFilePath2, FileMode.Create);
            string rndString = "This is a random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(rndString);
            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;
            byte[] byteFileData = new byte[rsByteArray.Length];
            for(int i = 0; i < rsByteArray.Length; i++)
            {
                byteFileData[i] = (byte)fs.ReadByte();
            }
            Console.Write(Encoding.Default.GetString(byteFileData));
            Console.WriteLine();
            fs.Close();
            string textFilePath3 = @"C:\Users\akhn3\source\repos\File Streams\File Streams\File3.txt";
            StreamWriter sw = File.CreateText(textFilePath3);
            sw.Write("This is a ");
            sw.WriteLine("sentence");
            sw.WriteLine("This is another sentence");
            sw.Close();
            StreamReader sr = File.OpenText(textFilePath3);
            Console.WriteLine("Peek : {0}", Convert.ToString(sr.Peek()));
            Console.WriteLine("Firts string : {0}", sr.ReadLine());
            Console.WriteLine("Second string : {0}", sr.ReadToEnd());
            sr.Close();
            string textFilePath4 = @"C:\Users\akhn3\source\repos\File Streams\File Streams\File4.dat";
            FileInfo datFile = new FileInfo(textFilePath4);
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());
            string randText = "Random text";
            int integer = 10;
            double dbl = 5.9;
            bw.Write(randText);
            bw.Write(integer);
            bw.Write(dbl);
            bw.Close();
            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();
            Console.ReadKey();
        }
    }
}
