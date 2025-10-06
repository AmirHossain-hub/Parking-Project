using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.DataLayer.Repositories;
using System.Data.Entity;

namespace Parking.DataLayer.Services
{
    class Repository : IRepository
    {
        public Parking_DBEntities1 db = new Parking_DBEntities1();
        public Repository(Parking_DBEntities1 context)
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

        public string GetCarInformationByOwner(OwnerInformation owner)
        {
            throw new NotImplementedException();
        }

        public string GetOwnerInformationByCar(CarInformation car)
        {
            throw new NotImplementedException();
        }

        public bool InsertCar(CarInformation car)
        {
            throw new NotImplementedException();
        }
    }
}
