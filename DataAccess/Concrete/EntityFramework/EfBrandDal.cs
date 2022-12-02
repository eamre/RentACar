using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarDatabaseContext>, IBrandDal
    {
        //public void Add(Brand entity)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        var addedEntity = context.Entry(entity); //referansı yakala
        //        addedEntity.State = EntityState.Added;   //bu aslında eklenecek bir nesne
        //        context.SaveChanges();                   //ve şimdi ekle
        //    }
        //}

        //public void Delete(Brand entity)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        var deletedEntity = context.Entry(entity); //referansı yakala
        //        deletedEntity.State = EntityState.Deleted;   //bu aslında eklenecek bir nesne
        //        context.SaveChanges();                   //ve şimdi ekle
        //    }
        //}

        //public Brand Get(Expression<Func<Brand, bool>> filter)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        return context.Set<Brand>().SingleOrDefault(filter);
                
        //    }
        //}

        //public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        return filter == null ?
        //            context.Set<Brand>().ToList() :
        //            context.Set<Brand>().Where(filter).ToList();
        //    }
        //}

        //public void Update(Brand entity)
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
