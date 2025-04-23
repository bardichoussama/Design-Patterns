using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    internal class Motorcycle: IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a motorcycle, feeling the wind");
        }
    }
}
