using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    internal class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck, carrying heavy load");
        }
    }
}
