using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Database myDBConnection = new Database();

            //Data Insertion
            string query = "insert into albums('title', 'artist') values(@title, @artist)";
            SQLiteCommand myCommand = new SQLiteCommand(query, myDBConnection.myConnection);
            myDBConnection.OpenConnection();
            myCommand.Parameters.AddWithValue("@title", "Havana");
            myCommand.Parameters.AddWithValue("@artist", "Camila Cabello");
            var result = myCommand.ExecuteNonQuery();
            myDBConnection.CloseConnection();

            Console.WriteLine("Rows added : {0}", result);
            Console.ReadKey();
        }
    }
}

