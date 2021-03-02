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
            //gun9();

            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User();
            ////{FirstName = "Okay ",LastName = "Genc",Email = "ogenc192@gmail.com",Password = "asdfg"});

            //foreach (var user in userManager.GetAll().Data)
            //{
            //    Console.WriteLine($"{user.Id}, {user.FirstName} {user.LastName}, {user.Email}");
            //}

            Console.WriteLine("---------Add Customer---------");
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer()
            {
                UserId = 1,
                CompanyName = "Company Name 1"
            });

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine($"{customer.UserId}, {customer.CompanyName}");
            }

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var add = rentalManager.Add(new Rental()
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Now,
            });

         

        }

        private static void gun9()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car()
            {
                BrandId = 1,
                Description = "Core Sonrası Araba 3",
                ColorId = 2,
                DailyPrice = 1000,
                ModelYear = 2019
            });

            Console.WriteLine("\n=============GetAll=============");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine($"CarId: {car.CarId}   BrandId: {car.BrandId}   ColorId: {car.ColorId}   " +
                                  $"Description: {car.Description}   DailyPrice: {car.DailyPrice}   ModelYear: {car.ModelYear}");
            }

            Console.WriteLine("\n=============GetCarsDetailDTO=============");
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"{car.Description}   {car.ColorName}   {car.BrandName}   {car.DailyPrice}");
            }

            Console.WriteLine("\n=============GetCarById=============");
            var id4Car = carManager.GetById(4);
            Console.WriteLine(
                $"CarId: {id4Car.Data.CarId}   BrandId: {id4Car.Data.BrandId}   ColorId: {id4Car.Data.ColorId}   " +
                $"Description: {id4Car.Data.Description}   DailyPrice: {id4Car.Data.DailyPrice}   ModelYear: {id4Car.Data.ModelYear}");
        }
    }  
}
    





