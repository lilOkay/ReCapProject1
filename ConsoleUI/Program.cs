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
                var result = carManager.GetCarDetails();
                if (result.Succes == true)
                {
                    foreach (var car in result.Data)
                    {
                        Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
                    }
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
        }
    }  
}
    





