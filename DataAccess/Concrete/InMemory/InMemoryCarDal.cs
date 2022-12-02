using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{
                    Id=1, BrandId=1, ColorId=2, DailyPrice=5000,Description="6 Yıllık Araba",ModelYear=2015
                },
                new Car{
                    Id=2, BrandId=6, ColorId=3, DailyPrice=6000,Description="4 Yıllık Araba",ModelYear=2017
                },
                new Car{
                    Id=3, BrandId=8, ColorId=4, DailyPrice=7000,Description="2 Yıllık Araba",ModelYear=2019
                },
                new Car{
                    Id=4, BrandId=2, ColorId=5, DailyPrice=8000,Description="8 Yıllık Araba",ModelYear=2013
                },
                new Car{
                    Id=5, BrandId=3, ColorId=6, DailyPrice=9000,Description="10 Yıllık Araba",ModelYear=2011
                }
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);

            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
