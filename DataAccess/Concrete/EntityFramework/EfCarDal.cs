using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }

        //public void Add(Car entity)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        var addedEntity = context.Entry(entity); //referansı yakala
        //        addedEntity.State = EntityState.Added;   //bu aslında eklenecek bir nesne
        //        context.SaveChanges();                   //ve şimdi ekle
        //    }
        //}

        //public void Delete(Car entity)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        var deletedEntity = context.Entry(entity); //referansı yakala
        //        deletedEntity.State = EntityState.Deleted;   //bu aslında eklenecek bir nesne
        //        context.SaveChanges();                   //ve şimdi ekle
        //    }
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        return context.Set<Car>().SingleOrDefault(filter);

        //    }
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        return filter == null ?
        //            context.Set<Car>().ToList() :
        //            context.Set<Car>().Where(filter).ToList();
        //    }
        //}

        //public void Update(Car entity)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        var updatedEntity = context.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }

        //}

    }
}
