using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask2
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is Driving");
        }
    }
}
