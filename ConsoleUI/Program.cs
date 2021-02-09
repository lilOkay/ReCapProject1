using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (CarDetailDto car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} model, {1} {2} Günlük Ücret : {3} / Renk : {4}", car.ModelYear, car.BrandName, car.Description, car.DailyPrice, car.ColorName);
            }
            carManager.Add(new Car { BrandId = 4, DailyPrice = 550, Description = "wmb", ColorId = 1, ModelYear = 2017 });
        }
    }  
}
    





