﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTasks
{
    class DeathStar : SpaceStation
    {
        public override void FireLaser()
        {
            Console.WriteLine("Pew pew pew");
        }
    }
}
