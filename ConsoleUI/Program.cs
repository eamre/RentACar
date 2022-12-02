using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result=rentalManager.Add(new Rental 
            {CarId = 1, CustomerId = 1, RentDate = new DateTime(2020, 07, 09)});
            //Console.WriteLine(result);
            Console.WriteLine(result.Message);

            //foreach (var car in carManager.GetCarsByBrandId(4))
            //{
            //    Console.WriteLine(car.Description);
            //}

            //Console.WriteLine( brandManager.Add(new Brand {BrandName = "YL" }).Message); 
            //Console.WriteLine( customerManager.Add(new Customer { 
            //UserId=1,
            //CompanyName="Tesla"
            //}).Message );

            Console.WriteLine(customerManager.Update(new Customer
            {
                CustomerId=2,
                UserId = 2,
                CompanyName = "Gm"
            }).Success);
            //brandManager.Delete(new Brand {BrandId=2002 });
            // Console.WriteLine(brandManager.GetById(1).Data.BrandName); 


            //brandManager.Delete(new Brand { BrandName = "Genesis", BrandId=7 });



            //colorManager.Add(new Color { ColorName = "Mor" });
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}
            //colorManager.Update(new Color { ColorId = 1003, ColorName="Gok" });
            //colorManager.Delete(new Color { ColorId = 1002 });



            //foreach (var car in carManager.GetCarDetailsDto())
            //{
            //    Console.WriteLine(car.CarName+" "+car.BrandName+" "+car.ColorName+" "+car.DailyPrice);
            //}

            //carManager.Add(new Car{
            //    BrandId=4,
            //    ColorId=2,
            //    ModelYear=2014,
            //    DailyPrice=2200,
            //    Description= "M"
            //});

        }
    }
}
