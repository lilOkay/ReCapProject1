using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        
            List<Car> _car;
        
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=2, ModelYear=2010, DailyPrice=307, Description="Hatchback"},
                new Car{ Id=2, BrandId=2, ColorId=1, ModelYear=2017, DailyPrice=940, Description="Sport"},
                new Car{ Id=3, BrandId=3, ColorId=1, ModelYear=2015, DailyPrice=490, Description="Arazi"},
                new Car{ Id=4, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=1050, Description="Sedan"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByDailyPrice(int carDailyPrice)
        {
            return _car.Where(p => p.DailyPrice > carDailyPrice).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
