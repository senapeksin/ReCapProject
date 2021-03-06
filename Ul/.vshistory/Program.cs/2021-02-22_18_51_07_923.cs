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
          //  CarTest();
            BrandTest();
          //  ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal()); ;
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            brandManager.Add(new Brand { BrandName = "BMW" });
          //  brandManager.Add(new Brand { BrandId = 1, BrandName = "Renault" });
           // brandManager.Delete(new Brand { BrandId = 2, BrandName = "Mercedes" });
           
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Id + " - " + car.BrandName + " - "
                    + car.ColorName + " - " + car.DailyPrice);
            }
        }
    }
}
