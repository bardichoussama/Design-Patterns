

using Simple_Factory;

var factory = new VehicleFactory();

IVehicle car = factory.CreateVehicle("CAR");
IVehicle truck = factory.CreateVehicle("TRUCK");
IVehicle moto = factory.CreateVehicle("MOTORCYCLE");

   car.Drive();
   truck.Drive();
moto.Drive();
