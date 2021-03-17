﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice= 145000, ModelYear = 2016, Description = "Orta Segment" },
                new Car{Id = 2, BrandId = 2, ColorId = 1, DailyPrice= 80000, ModelYear = 2008, Description = "Düşük-Orta Segment Araç" },
                new Car{Id = 3, BrandId = 1, ColorId = 2, DailyPrice= 900000, ModelYear = 2019, Description = "Yüksek Segment Araç" },
                new Car{Id = 4, BrandId = 3, ColorId = 3, DailyPrice= 35000, ModelYear = 2001, Description = "Düşük Segment Araç" },
                new Car{Id = 5, BrandId = 4, ColorId = 4, DailyPrice= 2650000, ModelYear = 2021, Description = "Çok Yüksek Segment Araç" }
            };
        }
        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void DeleteCar(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetCarsById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void UpdateCar(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
