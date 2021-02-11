﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);
            return new SuccesResult(Messages.CarAdded);//eğer biz bunu yapmazsak Add bize kızar bizden bir şey dödürmemizi ister
        }

        

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccesResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintananceTime);
            }

            //ben dataresult dödürüyorum çalıştığım tip <List<Car>>dır _carDal.GetAll()buda dödürdüğümd atadır truede işlem sonucu  "ürünler listelendi"ise kullanıcı bilgilendirici messajdır
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }



        public IResult Update(Car car)
        {
            if (car.CarName.Length >= 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            else
            {
                _carDal.Update(car);
                return new SuccesResult(Messages.CarUpdated);
            }
        }

        public IDataResult<Car> GetById(int car_id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == car_id));
        }

        public IDataResult<List<Car>> GetByBrandId(int brand_id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brand_id));
        }

        public IDataResult<List<Car>> GetByColorId(int color_id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c0 => c0.BrandId == color_id));
        }

        
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        
    }
}