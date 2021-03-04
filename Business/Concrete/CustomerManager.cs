using Buisness.ValidationRules.FluentValidation;
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
    public class CustomerManager : ICustomerService
    {
         ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("ICustomerService.Get")]
        public IResult Add(Customer entity)
        {
            _customerDal.Add(entity);
            return new SuccessResult(Messages.AddCustomerMessage);
        }
        [TransactionScopeAspect]
        [CacheRemoveAspect("ICustomerService.Get")]
        public IResult Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new SuccessResult(Messages.DeleteCustomerMessage);
        }

        [CacheAspect]
        public DataResult<Customer> Get(int id)
        {
            Customer customer = _customerDal.Get(p=>p.Id==id);
            if (customer==null)
            {
                return new ErrorDataResult<Customer>(Messages.GetErrorCustomerMessage);
            }
            else
            {
                return new SuccessDataResult<Customer>(Messages.GetSuccessCustomerMessage);
            }
        }

        [CacheAspect]
        public DataResult<List<Customer>> GetAll()
        {
            List<Customer> customers = _customerDal.GetAll();
            if (customers.Count==0)
            {
                return new ErrorDataResult<List<Customer>>(Messages.GetErrorCustomerMessage);
            }
            else
            {
                return new SuccessDataResult<List<Customer>>(Messages.GetSuccessCustomerMessage);
            }
        }

        [ValidationAspect(typeof(CustomerValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("ICustomerService.Get")]
        public IResult Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult(Messages.EditCustomerMessage);
        }
    }
}
