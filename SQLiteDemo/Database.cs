using System.IO;
using System.Data.SQLite;
using System;
using System.Data;

namespace SQLite_Demo
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite3");
            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                Console.WriteLine("Database File Created");
            }
        }


        public void OpenConnection()
        {
            if(myConnection.State != ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if(myConnection.State != ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
