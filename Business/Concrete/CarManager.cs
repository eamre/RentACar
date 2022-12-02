using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            
           
            //else
            //{
            //    return new ErrorResult(Messages.CarNameInvalid);
            //}
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll2()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);

        }

        public IDataResult <Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>( _carDal.Get(car => car.Id == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsDto()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetProductDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            //her c için c'nin BrandId'si benim gönderdiğim id ye yani BrandId'ye eşitse onları filtrele
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
