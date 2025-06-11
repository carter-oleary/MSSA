using Assignment_10._3.Data;
using Assignment_10._3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10._3.Services
{
    public class CRUD
    {
        public void AddCar(Car car)
        {
            Records.carContext.CarSet.Add(car);
            Records.carContext.SaveChanges();
        }

        public Car FindCar(int vin)
        {
            return Records.carContext.CarSet.Find(vin);
        }

        public void UpdateCar(int vin, Car car)
        {
            var existingCar = Records.carContext.CarSet.Find(vin);
            if(existingCar != null)
            {
                existingCar.Make = car.Make;
                existingCar.Model = car.Model;
                existingCar.Year = car.Year;
                existingCar.Price = car.Price;
                Records.carContext.SaveChanges();
            }
        }

        public List<Car> GetAllCars()
        {
            return Records.carContext.CarSet.ToList();
        }

        public int GetMaxVin()
        {
            return Records.carContext.CarSet.Max(e => e.VIN);
        }

        public void DeleteCar(int vin)
        {
            var car = Records.carContext.CarSet.Find(vin);
            if(car != null)
            {
                Records.carContext.CarSet.Remove(car);
                Records.carContext.SaveChanges();
            }
        }
    }
}
