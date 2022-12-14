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
    public class EfColorDal : EfEntityRepositoryBase<Color,CarDatabaseContext>, IColorDal
    {
        //public void Add(Color entity)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        var addedEntity = context.Entry(entity); //referansı yakala
        //        addedEntity.State = EntityState.Added;   //bu aslında eklenecek bir nesne
        //        context.SaveChanges();                   //ve şimdi ekle
        //    }
        //}

        //public void Delete(Color entity)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        var deletedEntity = context.Entry(entity); //referansı yakala
        //        deletedEntity.State = EntityState.Deleted;   //bu aslında eklenecek bir nesne
        //        context.SaveChanges();                    //ve şimdi ekle
        //    }
        //}

        //public Color Get(Expression<Func<Color, bool>> filter)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        return context.Set<Color>().SingleOrDefault(filter);
        //    }
        //}

        //public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        //{
        //    using (CarDatabaseContext context = new CarDatabaseContext())
        //    {
        //        return filter == null ?
        //            context.Set<Color>().ToList() :
        //            context.Set<Color>().Where(filter).ToList();
        //    }
        //}

        //public void Update(Color entity)
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
