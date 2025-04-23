using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    internal class VehicleFactory
    {
        public IVehicle CreateVehicle(string type)
        {
            if (type == null) return null;

            switch (type) {
                case "CAR":
                    return new Car();
                case "TRUCK":
                    return new Truck();
                case "MOTORCYCLE":
                    return new Motorcycle();
                  
                default:
                    return null;
            }
        }

    }
}
