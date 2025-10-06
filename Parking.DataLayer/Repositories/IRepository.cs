using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.DataLayer.Repositories
{
    public interface IRepository
    {
        bool InsertCar(GeneralInformation general);
        bool UpdateCar(CarInformation car);
        bool DeleteCar(CarInformation car);
        bool DeleteCar(string NumberPlate);
        void UpdateVehicleExit(string NumberPlate, DateTime exitTime, int fee);
        string GetVehicleType(string NumberPlate);
        List<GeneralInformation> GetActiveParkings();
        List<GeneralInformation> GetAllInfo(GeneralInformation general);
        CarInformation GetOwnerInformationByCar(CarInformation car);
        CarInformation GetCarInformationByNumberPlate(string NumberPlate);
        CarInformation GetCarInformationByPhoneNumber(int PhoneNumber);
        OwnerInformation GetOwnerInformationByName(string FullName);
        
    }
}
