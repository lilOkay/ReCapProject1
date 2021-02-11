using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
                   //T mizi burada Car verdik özel olarak
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int car_id);
        IDataResult<List<Car>> GetByBrandId(int brand_id);
        IDataResult<List<Car>> GetByColorId(int color_id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
