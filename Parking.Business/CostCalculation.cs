using Parking.DataLayer;
using Parking.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Business
{
    public class CostCalculation
    {
        public UnitofWork db;

        public decimal CalculateParkingFee(string typeCar, TimeSpan duration, string numberPlate, UnitofWork db)
        {
            
            if (string.IsNullOrEmpty(typeCar))
                throw new ArgumentException("نوع وسیله نقلیه نمی‌تواند خالی باشد");
            if (string.IsNullOrEmpty(numberPlate))
                throw new ArgumentException("شماره پلاک نمی‌تواند خالی باشد");
            if (db == null)
                throw new ArgumentNullException(nameof(db), "UnitofWork cannot be null");
            //
            decimal hourlyRate;
            decimal FirstHourRate;
            switch (typeCar.ToLower())
            {
                case "سواری":
                    hourlyRate = 700;
                    FirstHourRate = 630;
                    break;
                case "موتورسیکلت":
                    hourlyRate = 650;
                    FirstHourRate = 550;
                    break;
                case "سنگین":
                    hourlyRate = 830;
                    FirstHourRate = 700;
                    break;
                default:
                    throw new ArgumentException("نوع وسیله نقلیه نامعتبر است");
            }
            //
            double totalHours = duration.TotalHours;
            decimal totalCost;
            if (totalHours <= 1)
            {
                totalCost = FirstHourRate;
            }
            else
            {
                totalCost = FirstHourRate + (decimal)(Math.Ceiling(totalHours - 1)) * hourlyRate;
            }
            //

            var generalInfo = db.GenericRepository.Get(c => c.NumberPlate == numberPlate).FirstOrDefault();
            if (generalInfo != null)
            {
                generalInfo.Fee = totalCost;
                generalInfo.ExitDate = DateTime.Now;
                generalInfo.CarSituation = "خروجی";
                db.GenericRepository.Update(generalInfo);
                db.Save();
            }
            else
            {
                throw new InvalidOperationException("رکورد وسیله نقلیه با این شماره پلاک یافت نشد");
            }
            return totalCost;
        }
    }
}


