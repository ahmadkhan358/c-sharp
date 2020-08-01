using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            bankAccount acct = new bankAccount(10);
            Thread[] threads = new Thread[15];
            Thread.CurrentThread.Name = "main";
            for(int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.Issuewithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }
            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} alive : {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} alive : {1}", threads[i].Name, threads[i].IsAlive);
            }
            Console.WriteLine("Current priority : {0}",Thread.CurrentThread.Priority);
            Console.WriteLine("Thread Ending : {0}",Thread.CurrentThread.Name);
            Console.ReadKey();
        }
    }
}
class bankAccount
{
    private Object lockacct = new Object();
    double balance { get; set; }
    public bankAccount(double b)
    {
        balance = b;
    }
    public double Withdraw(double amt)
    {
        if ((balance - amt) < 0)
        {
            Console.WriteLine($"Sorry ${balance} in account");
            return balance;
        }
        lock (lockacct)
        {
            if (balance >= amt)
            {
                Console.WriteLine("Removed ${0} and ${1} left in account", amt, (balance - amt));
                balance -= amt;
            }
            return balance;
        }
    }
    public void Issuewithdraw()
    {
        Withdraw(1);
    }
}
