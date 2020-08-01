﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powBut = new PowerButton(TV);
            powBut.Execute();
            powBut.Undo();
            Console.ReadKey();
        }
    }
}
