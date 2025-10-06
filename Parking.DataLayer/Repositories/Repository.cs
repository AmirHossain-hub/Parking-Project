using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Parking.DataLayer.Context;

namespace Parking.DataLayer.Repositories
{
    public class Repository : IRepository
    {
        Parking_DBEntities3 db = new Parking_DBEntities3();
        UnitofWork dbo = new UnitofWork();

        public Repository(Parking_DBEntities3 context)
        {
            db = context;
        }
        public bool ExitCar(CarInformation car)
        {
            try
            {
                db.Entry(car).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

       
        public bool InsertCar(CarInformation car)
        {
            try
            {
                db.CarInformations.Add(car);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public OwnerInformation GetCarInformationByOwner(OwnerInformation owner)
        {
            return db.OwnerInformations.Find(owner);
        }

        public CarInformation GetOwnerInformationByCar(CarInformation car)
        {
            return db.CarInformations.Find(car);
        }

        public bool UpdateCar(CarInformation car)
        {
            var local = db.Set<CarInformation>()
                .Local
                .FirstOrDefault(c => c.NumberPlate == car.NumberPlate);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(car).State = EntityState.Modified;
            return true;
        }

        public bool DeleteCar(CarInformation car)
        {
            try
            {
                db.Entry(car).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCar(string NumberPlate)
        {
            try
            {
                var car = GetCarsByNumberPlate(NumberPlate);
                DeleteCar(car);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public CarInformation GetCarsByNumberPlate(string NumberPlate)
        {
            return db.CarInformations.Find(NumberPlate);
        }

        public OwnerInformation GetOwnerInformationByName(string FullName)
        {
            return db.OwnerInformations.Find(FullName);
        }

        public CarInformation GetCarInformationByNumberPlate(string NumberPlate)
        {
            return db.CarInformations.Find(NumberPlate);
        }

        public CarInformation GetCarInformationByPhoneNumber(int PhoneNumber)
        {
            return db.CarInformations.Find(PhoneNumber);
        }
        
        public CarInformation GetCarsByNumberPlate(int NumberPlate)
        {
            return db.CarInformations.Find(NumberPlate);
        }
        
        public List<GeneralInformation> GetAllInfo(GeneralInformation general)
        {
            return db.GeneralInformations.ToList();
        }

        public void UpdateVehicleExit(string NumberPlate, DateTime exitTime, int fee)
        {
            var vehicle = db.GeneralInformations.Find(NumberPlate);
            if (vehicle != null)
            {
                vehicle.ExitDate = exitTime;
                vehicle.Fee = fee;
                db.SaveChanges();
            }
        }
        
        public List<GeneralInformation> GetActiveParkings()
        {
            return db.GeneralInformations
                .Where(v => v.ExitDate == null)
                .ToList();
        }

        public bool InsertCar(GeneralInformation general)
        {
            try
            {
                db.GeneralInformations.Add(general);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetVehicleType(string NumberPlate)
        {
            GeneralInformation general = new GeneralInformation();
            // Assuming you set the VehicleType property somewhere based on the numberPlate
            return general.VehicleType;
        }
    }
}
