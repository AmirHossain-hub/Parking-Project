using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.ViewModels.Vehicles
{
    class ListVehicleViewModel
    {
        public class Vehicle
        {
        public string Engine { get; set; }
        public string Body { get; set; }
        }

        public class Car : Vehicle { }
        public class MotorCycle:Vehicle{ }
        public class Truck : Vehicle { }

}
}
