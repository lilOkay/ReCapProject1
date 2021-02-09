using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Name.Length >= 2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("\nCar name must be more than one character!".ToUpper());
            }
        }

        public IEnumerable<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int car_id)
        {
            return _carDal.GetAll(p => p.CarId == car_id);
        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            return _carDal.GetCarDetailDtos();
        }

        public void Update(Car car)
        {
            if (car.Name.Length >= 2)
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("Car name must be more than one character");
            }
        }
    }
}