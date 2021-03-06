﻿using Buisness.ValidationRules.FluentValidation;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
         IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Add(Rental entity)
        {
            var isDeliveryControl = IsDelivery(entity.CarId);
            if (isDeliveryControl.Success)
            {
                _rentalDal.Add(entity);
                return new SuccessResult(Messages.AddRentalMessage);
            }
            else
            {
                return new ErrorResult(isDeliveryControl.Message);
            }
        }

        [TransactionScopeAspect]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult(Messages.DeleteRentalMessage);
        }

        [CacheAspect]
        public DataResult<Rental> Get(int id)
        {
            Rental rental = _rentalDal.Get(p => p.Id == id);
            if (rental == null)
            {
                return new ErrorDataResult<Rental>(Messages.GetErrorRentalMessage);
            }
            else
            {
                return new SuccessDataResult<Rental>(rental, Messages.GetSuccessRentalMessage);
            }
        }

        [CacheAspect]
        public DataResult<List<Rental>> GetAll()
        {
            List<Rental> rentals = _rentalDal.GetAll();
            if (rentals.Count == 0)
            {
                return new ErrorDataResult<List<Rental>>(Messages.GetErrorRentalMessage);
            }
            else
            {
                return new SuccessDataResult<List<Rental>>(rentals, Messages.GetSuccessRentalMessage);
            }
        }

        public DataResult<bool> IsDelivery(int carId)
        {
            List<Rental> isDeliveryCarList = _rentalDal.GetAll(p => p.CarId == carId);
            if (isDeliveryCarList.Count>0)
            {
                return new ErrorDataResult<bool>(false, Messages.CarNotAvaible);
            }
            return new SuccessDataResult<bool>(true, Messages.CarAvaible);
        }

        [ValidationAspect(typeof(RentalValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult(Messages.EditRentalMessage);
        }
    }
}
