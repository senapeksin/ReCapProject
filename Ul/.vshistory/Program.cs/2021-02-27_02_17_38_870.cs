﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Ul
{
    class Program
    {
        static void Main(string[] args)
        {
           CarTest();
          // BrandTest(); //sorun yok
          // ColorTest();//sorun yok
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
           // colorManager.Add(new Color { ColorId=4, ColorName = "Yeşil" });
           //  colorManager.Delete(new Color { ColorId = 4, ColorName = "Yeşil" });
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal()); ;
             brandManager.Delete(new Brand { BrandId = 3, BrandName = "BMW" });
           // brandManager.Add(new Brand { BrandName = "BMW", BrandId = 3 }) ;

            //foreach (var brand in brandManager.GetAll().Data)
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
             carManager.Add(new Car { Id = 1,BrandId=1, ColorId=2, DailyPrice=1,Description="İkinci araba mercedes",ModelYear=2019});
           // carManager.Delete(new Car { Id=2005, BrandId=2,ColorId=2 });
            //foreach (var car in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine(car.Id + " - " + car.BrandName + " - "
            //        + car.ColorName + " - " + car.DailyPrice);
            //}
        }
    }
}
