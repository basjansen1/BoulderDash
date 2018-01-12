<<<<<<< HEAD
using BoulderDashLibrary.Controller;
using BoulderDashLibrary.Model;
=======
﻿using BoulderDashLibrary.Controller;
>>>>>>> 341be8ec6266f8225312036a49f549e0acb897f1
using System;
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
            new GameController().StartGame();

            Console.ReadLine();
        }
    }
}
