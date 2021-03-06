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
    public class ColorManager : IColorSevice
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IColorService.Get")]
        public IResult Add(Color color)
        {
            
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        [TransactionScopeAspect]
        [CacheRemoveAspect("IColorService.Get")]
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Color>> GetAll()
        {

            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<Color> GetById(int color_id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == color_id));
        }

        [ValidationAspect(typeof(ColorValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IColorService.Get")]
        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);

        }

        IDataResult<List<Color>> IColorSevice.GetById(int color_id)
        {
            throw new NotImplementedException();
        }
    }
}
