using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        List<Car> GetAll();
        List<Car> GetById(int car_id);
        List<CarDetailDto> GetCarDetailDto();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
