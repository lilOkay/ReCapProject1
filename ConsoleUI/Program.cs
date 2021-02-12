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
            //CarTest();
            //BrandTest();
            //ColorTest();
            //CarDetailTest();

            RentalManager rentalMenager = new RentalManager(new EfRentalDal());
            var result = rentalMenager.GetAll();
            if (result.Success == true)
            {
                foreach (var rent in result.Data)
                {
                    Console.WriteLine(rent.CarId + "--" + rent.CustomerId + "--" + rent.RentDate + "--" + rent.ReturnDate);
                }
            }

        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            carManager.Add(new Car { BrandId = 5, ColorId = 3, DailyPrice = 750, Description = "Sport Araba", ModelYear = 2013 });
            if (result.Succes == true)
            {
                foreach (var details in result.Data)
                {
                    Console.WriteLine(details.CarId + "--" + details.BrandName + "--" + details.Description + "--" + details.ColorName + "--" + details.DailyPrice + "$");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }  
}
    





