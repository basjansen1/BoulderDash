﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BoulderDash
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(TimerCallBack, null, 0, 2000);

            Console.ReadLine();
        }

        private static void TimerCallBack(Object o)
        {
            Console.WriteLine("Datum van vandaag: " + DateTime.Now);
        }
    }
}
