using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.ViewModels.CarInfo
{
    class ListCarViewModel
    {
        public int NumberPlate { get; set; }
        public string VehicleType { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
